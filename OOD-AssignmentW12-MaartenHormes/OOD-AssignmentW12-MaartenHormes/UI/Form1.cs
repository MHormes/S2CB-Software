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
    public partial class Form1 : Form
    {
        WorkshopManager WM;
        PersonManager PM;
        bool selectedBuilding = true;
        IWorkshop workshopToEdit;
        public Form1()
        {
            InitializeComponent();
            WM = new WorkshopManager();
            PM = new PersonManager();
            rbWorkshopInBuilding.Checked = true;
            rbPersonStudent.Checked = true;
        }

        //WORKSHOPS

        //Button click for creating a new workshop
        private void btnCreateWorkshop_Click(object sender, EventArgs e)
        {
            //method for creating workshop
            var create = WM.CreateNewWorkshop(rbWorkshopInBuilding.Checked, tbxWorkshopName.Text, tbxWorkshopDescription.Text, tbxMaxCapacity.Text, dtpWorkshopDate.Value, tbxWorkshopURL.Text, tbxWorkshopAdress.Text, tbxWorkshopRoomNmr.Text);
            if(create != null)
            {
                MessageBox.Show(create.Message);
                return; 
            }
            UpdateWorkshopListbox();
        }

        //Button click for updating the selected workshop
        private void btnUpdateWorkshop_Click(object sender, EventArgs e)
        {
            lbxExpiredWorkshops.Enabled = true;
            if (lbxAvailableWorkshops.SelectedIndex != -1)
            {
                //create temp object to save the name of workshop before the edit
                IWorkshop workshopToEdit = (IWorkshop)lbxAvailableWorkshops.SelectedItem;
                //method for updating workshop
                var update = WM.UpdateWorkshop(workshopToEdit.Name, tbxWorkshopName.Text, tbxWorkshopDescription.Text, tbxMaxCapacity.Text, dtpWorkshopDate.Value, tbxWorkshopURL.Text, tbxWorkshopAdress.Text, tbxWorkshopRoomNmr.Text);
                if (update != null)
                {
                    MessageBox.Show(update.Message);
                    return;

                }
                UpdateWorkshopListbox();

                //Enable radiobuttons
                rbWorkshopOnline.Enabled = true;
                rbWorkshopInBuilding.Enabled = true;
                btnCreateWorkshop.Enabled = true;
                return;
            }
            MessageBox.Show("Please select an available workshop before clicking the button");
        }

        //button click for removing a workshop
        private void btnRemoveWorkshop_Click(object sender, EventArgs e)
        {
            IWorkshop workshopToDelete = null;
            if (lbxAvailableWorkshops.SelectedIndex != -1)
            {
                // create temp object to save the name of workshop before the delete
                workshopToDelete = (IWorkshop)lbxAvailableWorkshops.SelectedItem;
            }
            else if (lbxExpiredWorkshops.SelectedIndex != -1)
            {
                // create temp object to save the name of workshop before the delete
                workshopToDelete = (IWorkshop)lbxExpiredWorkshops.SelectedItem;
            }
            lbxExpiredWorkshops.Enabled = true;
            if (workshopToDelete != null)
            {
                //method for deleting workshop
                var delete = WM.DeleteWorkshop(workshopToDelete);
                if (delete != true)
                {
                    MessageBox.Show("Delete was unsucessfull");
                    return;
                }
                UpdateWorkshopListbox();
                //Enable create button
                btnCreateWorkshop.Enabled = true;
                return;
            }
            
            MessageBox.Show("Please select a workshop before clicking the button");
        }

        //button click for showing the details of the selected workshop
        private void btnShowDetailsWorkshop_Click(object sender, EventArgs e)
        {
            if(lbxAvailableWorkshops.SelectedIndex != -1)
            {
                //create temp object to save the name of workshop before the edit
                workshopToEdit = (IWorkshop)lbxAvailableWorkshops.SelectedItem;
                FillTexboxesForDetailPage(workshopToEdit);
                tabControl1.SelectedTab = tpWorkshopDetails;
                return;
            }
            else if(lbxExpiredWorkshops.SelectedIndex != -1)
            {
                //create temp object to save the name of workshop before the edit
                workshopToEdit = (IWorkshop)lbxExpiredWorkshops.SelectedItem;
                FillTexboxesForDetailPage(workshopToEdit);
                tabControl1.SelectedTab = tpWorkshopDetails;
                return;
            }
            MessageBox.Show("Please select a workshop to view the details");
        }

        //button click for setting a workshop as started
        private void btnStartWorkshop_Click(object sender, EventArgs e)
        {
            workshopToEdit.Started = true;
            tabControl1.SelectedTab = tpWorkshop;
            btnCreateWorkshop.Enabled = true;
            lbxExpiredWorkshops.Enabled = true;
            UpdateWorkshopListbox();
        }


        //PERSONS

        //button click for adding a person
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            //method for creating a new person
            var create = PM.AddNewPerson(rbPersonStudent.Checked, tbxPersonName.Text, tbxPersonPcn.Text, tbxPersonEmail.Text);
            if (create != null)
            {
                MessageBox.Show(create.Message);
                return;
            }
            UpdatePersonListbox();
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            UpdatePersonView();

            IPerson personToEdit = null;
            if(lbxTeachers.SelectedIndex != -1)
            {
                personToEdit = (IPerson)lbxTeachers.SelectedItem;
                
            }
            else if(lbxStudents.SelectedIndex != 1)
            {
                personToEdit = (IPerson)lbxStudents.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select a person to edit before clicking the button");
                return;
            }

            if(personToEdit != null)
            {
                var update = PM.UpdatePerson(personToEdit, tbxPersonName.Text, tbxPersonPcn.Text, tbxPersonEmail.Text);
                if(update != null)
                {
                    MessageBox.Show(update.Message);
                    return;
                }
                UpdatePersonListbox();
            }
            
        }

        //button click for removing a person
        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            UpdatePersonView();

            IPerson personToDelete = null;
            if(lbxTeachers.SelectedIndex != -1)
            {
                personToDelete = (IPerson)lbxTeachers.SelectedItem;
            }
            else if(lbxStudents.SelectedIndex != -1)
            {
                personToDelete = (IPerson)lbxStudents.SelectedItem;
            }
            
            if (personToDelete != null)
            {
                if (!PM.DeletePerson(personToDelete))
                {
                    MessageBox.Show("Delete was unsucessfull");
                    return;
                }
                UpdatePersonListbox();
            }
            else
            {
                MessageBox.Show("Please select a person before clicking the button");
            }
        }

        //button for assigning persons to a workshop.
        private void btnAssignToWorkshop_Click(object sender, EventArgs e)
        {
            UpdatePersonView();
        }


        //METHODS FOR UPDATING GUI ON USER INPUT

        //Enable/Disable textboxes for adding workshop based on the type of workshop to add
        private void rbWorkshopInBuilding_CheckedChanged(object sender, EventArgs e)
        {
            tbxWorkshopURL.Visible = !selectedBuilding;
            label5.Visible = !selectedBuilding;

            tbxWorkshopRoomNmr.Visible = selectedBuilding;
            tbxWorkshopAdress.Visible = selectedBuilding;
            label6.Visible = selectedBuilding;

            selectedBuilding = !selectedBuilding;
        }

        //Method to call for refreshing the listbox with all workshops
        public void UpdateWorkshopListbox()
        {
            lbxAvailableWorkshops.Items.Clear();
            lbxExpiredWorkshops.Items.Clear();
            foreach(IWorkshop workshop in WM.GetWorkshops())
            {
                if (workshop.Date >= DateTime.Now && workshop.Started == false)
                {
                    lbxAvailableWorkshops.Items.Add(workshop);
                }
                else
                {
                    lbxExpiredWorkshops.Items.Add(workshop);
                }
                
            }
        }

        //method to call for refreshing the listboxes of the persons
        public void UpdatePersonListbox()
        {
            lbxTeachers.Items.Clear();
            lbxStudents.Items.Clear();
            foreach(IPerson person in PM.GetPersons())
            {
                if(person is Teacher)
                {
                    lbxTeachers.Items.Add(person);
                }
                else
                {
                    lbxStudents.Items.Add(person);
                }
            }
        }

        //Method for filling textboxes when user selects workshop from the listbox
        private void lbxAvailableWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disable Radiobuttons
            rbWorkshopInBuilding.Enabled = false;
            rbWorkshopOnline.Enabled = false;

            //Check if something is selected
            if (lbxAvailableWorkshops.SelectedIndex != -1)
            {
                //Create temp object and fill boxes
                IWorkshop workshop = (IWorkshop)lbxAvailableWorkshops.SelectedItem;
                tbxWorkshopName.Text = workshop.Name;
                tbxWorkshopDescription.Text = workshop.Description;
                tbxMaxCapacity.Text = workshop.MaxCapacity.ToString();
                btnCreateWorkshop.Enabled = false;
                lbxExpiredWorkshops.Enabled = false;

                //fill boxes for adress and url based on the type of IWorkshop
                if (workshop is WorkshopInBuilding)
                {
                    tbxWorkshopAdress.Text = ((WorkshopInBuilding)workshop).Adress;
                    tbxWorkshopRoomNmr.Text = ((WorkshopInBuilding)workshop).RoomNmr.ToString();
                    rbWorkshopInBuilding.Checked = true;
                    return;
                }
                tbxWorkshopURL.Text = ((WorkshopOnline)workshop).URL;
                rbWorkshopOnline.Checked = true;
            }
        }

        //method for filling texboxes when user selects a teacher
        private void lbxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxTeachers.SelectedIndex != -1)
            {
                lbxStudents.Enabled = false;
                btnAddPerson.Enabled = false;
                IPerson person = (IPerson)lbxTeachers.SelectedItem;
                tbxPersonName.Text = person.Name;
                tbxPersonPcn.Text = person.PCN.ToString();
                tbxPersonEmail.Text = person.Email;

                if(person is Teacher)
                {
                    rbPersonTeacher.Checked = true;
                    rbPersonTeacher.Enabled = false;
                    rbPersonStudent.Checked = false;
                    rbPersonStudent.Enabled = false;
                }
            }
        }

        //method for filling texboxes when user selects a student
        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxStudents.SelectedIndex != -1)
            {
                lbxTeachers.Enabled = false;
                btnAddPerson.Enabled = false;
                IPerson person = (IPerson)lbxStudents.SelectedItem;
                tbxPersonName.Text = person.Name;
                tbxPersonPcn.Text = person.PCN.ToString();
                tbxPersonEmail.Text = person.Email;

                if (person is Student)
                {
                    rbPersonTeacher.Checked = false;
                    rbPersonTeacher.Enabled = false;
                    rbPersonStudent.Checked = true;
                    rbPersonStudent.Enabled = false;
                }
            }
        }
        //method for fillin the textboxes on the view workshop detail page
        public void FillTexboxesForDetailPage(IWorkshop workshop)
        {
            tbxWorkshopDetailsName.Text = workshop.Name;
            tbxWorkshopDetailsDescription.Text = workshop.Description;
            tbxWorkshopDetailsMaxCap.Text = workshop.MaxCapacity.ToString();

            if (workshop.Started == true)
            {
                btnEnrolAttendees.Enabled = false;
                btnRemoveSelectedStudent.Enabled = false;
                btnAssignTeacher.Enabled = false;
                btnRemoveSelectedTeacher.Enabled = false;
                btnStartWorkshop.Enabled = false;
            }

            //fill boxes for adress and url based on the type of IWorkshop
            if (workshop is WorkshopInBuilding)
            {
                tbxWorkshopDetailsAdress.Visible = true;
                tbxWorkshopDetailsRoomNmr.Visible = true;
                tbxWorkshopDetailsURL.Visible = false;
                label7.Visible = true;
                label8.Visible = false;
                tbxWorkshopDetailsAdress.Text = ((WorkshopInBuilding)workshop).Adress;
                tbxWorkshopDetailsRoomNmr.Text = ((WorkshopInBuilding)workshop).RoomNmr.ToString();
                return;
            }
            tbxWorkshopDetailsAdress.Visible = false;
            tbxWorkshopDetailsRoomNmr.Visible = false;
            tbxWorkshopDetailsURL.Visible = true;
            label7.Visible = false;
            label8.Visible = true;
            tbxWorkshopDetailsURL.Text = ((WorkshopOnline)workshop).URL;

            
        }

        //back button on the workshop details page
        private void btnWorkshopDetailsBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpWorkshop;
            btnCreateWorkshop.Enabled = true;
            lbxExpiredWorkshops.Enabled = true;
        }

        //method for updating elements in person view
        public void UpdatePersonView()
        {
            lbxTeachers.Enabled = true;
            lbxStudents.Enabled = true;
            rbPersonStudent.Enabled = true;
            rbPersonTeacher.Enabled = true;
            btnAddPerson.Enabled = true;
        }
        
    }
}
