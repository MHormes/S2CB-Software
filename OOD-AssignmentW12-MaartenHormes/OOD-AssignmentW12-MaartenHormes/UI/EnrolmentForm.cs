using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_AssignmentW12_MaartenHormes
{
    public partial class EnrolmentForm : Form
    {
        WorkshopManager WM;
        PersonManager PM;
        bool teacher;
        IWorkshop workshopToEdit;
        public EnrolmentForm(WorkshopManager OldWM, PersonManager OldPM, bool forTeacher, IWorkshop workshop)
        {
            InitializeComponent();
            WM = OldWM;
            PM = OldPM;
            teacher = forTeacher;
            workshopToEdit = workshop;

            FillListboxes();
        }

        //method for filling the listboxes
        public void FillListboxes()
        {
            if (teacher)
            {
                foreach (IPerson teacher in PM.GetPersons())
                {
                    if(teacher is Teacher && !workshopToEdit.GetTeachers().Contains(teacher))
                    {
                        lbxAvailable.Items.Add(teacher);
                    }
                    else if(teacher is Teacher && workshopToEdit.GetTeachers().Contains(teacher))
                    {
                        lbxAssigned.Items.Add(teacher);
                    }
                }
            }
            else
            {
                foreach(IPerson person in PM.GetPersons())
                {
                    if (workshopToEdit.GetStudents().Contains(person))
                    {
                        lbxAssigned.Items.Add(person);
                    }
                    else
                    {
                        lbxAvailable.Items.Add(person);
                    }
                }
            }
            
        }

        private void btnEnrolmentRemove_Click(object sender, EventArgs e)
        {
            if(lbxAssigned.SelectedIndex != -1)
            {
                IPerson person = (IPerson)lbxAssigned.SelectedItem;

                if (teacher)
                {
                    workshopToEdit.RemoveTeacher((Teacher)person);
                }
                else
                {
                    workshopToEdit.RemovePerson(person);
                }
                
            }
            MessageBox.Show("Please select someone before clicking the button");
        }

        private void btnEnrolmentAssign_Click(object sender, EventArgs e)
        {
            if (lbxAvailable.SelectedIndex != -1)
            {
                IPerson person = (IPerson)lbxAvailable.SelectedItem;
                if (teacher)
                {
                    if(WM.AssignTeacher(workshopToEdit, person) != null)
                    {
                        MessageBox.Show(WM.AssignTeacher(workshopToEdit, person).Message);
                    }
                }
                else
                {
                    if(!WM.EnrolPerson(workshopToEdit, person))
                    {
                        MessageBox.Show("Workshop is full");
                    }
                }
                return;
            }
            MessageBox.Show("Please select someone before clicking the button");
        }
    }
}
