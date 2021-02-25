using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemPart1
{
    public partial class Form1 : Form
    {
        Administration admin;
        bool teacherBox;
        public Form1()
        {
            InitializeComponent();
            admin = new Administration();
            rdbStudent.Checked = true;
            teacherBox = false;
            tbxSalary.Enabled = false;
            tbxECs.Enabled = true;
            
        }

        private void btnAddToAdministration_Click(object sender, EventArgs e)
        {
            if (admin.AlreadyExcists(Convert.ToInt32(tbxPCN.Text)))
            {
                MessageBox.Show("Someone already has this pcn");
                return;
            }

            if (rdbTeacher.Checked)
            {
                Teacher nT = new Teacher(Convert.ToInt32(tbxAge.Text), tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxYearsAtSchool.Text));
                admin.AddPerson(nT);
            }
            else
            {
                Student nS = new Student(Convert.ToInt32(tbxAge.Text), tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxYearsAtSchool.Text));
                admin.AddPerson(nS);
            }
        }

        private void btnShowPersons_Click(object sender, EventArgs e)
        {
            lbxShowInfo.Items.Clear();

            if(cbShowPerson.SelectedIndex == 0)
            {
                foreach(Person p in admin.GetPerson())
                {
                    lbxShowInfo.Items.Add(p);
                }
            }
            else if(cbShowPerson.SelectedIndex == 1)
            {
                foreach(Person p in admin.GetPerson())
                {
                    if(p is Teacher)
                    {
                        lbxShowInfo.Items.Add(p);
                    }
                }
            }
            else
            {
                foreach (Person p in admin.GetPerson())
                {
                    if (p is Student)
                    {
                        lbxShowInfo.Items.Add(p);
                    }
                }
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (admin.GetPerson(Convert.ToInt32(tbxSearchPCN.Text)) != null)
            {
                lbxShowInfo.Items.Clear();
                lbxShowInfo.Items.Add(admin.GetPerson(Convert.ToInt32(tbxSearchPCN.Text)));
                return;
            }
            MessageBox.Show("No student found with supplied PCN");
        }

        private void btnStartNewSchoolYearTeach_Click(object sender, EventArgs e)
        {
            Person p = admin.GetPerson(Convert.ToInt32(tbxSearchPCN.Text));
            if (p != null)
            {
                p.StartAnotherSchoolyear();
                return;
            }
            MessageBox.Show("No one found with supplied PCN");
        }

        private void btnCelebrateBirthday_Click(object sender, EventArgs e)
        {
            Person p = admin.GetPerson(Convert.ToInt32(tbxSearchPCN.Text));
            if(p != null)
            {
                p.CelebrateBirthday();
                return;
            }
            MessageBox.Show("No one found with supplied PCN");
        }


        private void btnAddECs_Click(object sender, EventArgs e)
        {
            Person p = admin.GetPerson(Convert.ToInt32(tbxSearchPCN.Text));
            if (p != null)
            {
                if(p is Student)
                {
                    ((Student)p).AddECs(Convert.ToInt32(tbxAddECs.Text));
                    return;
                }
                MessageBox.Show("Only students can have EC's");
                return;
            }
            MessageBox.Show("No student found with supplied PCN");
        }




        private void btnPromote_Click(object sender, EventArgs e)
        {
            Person p = admin.GetPerson(Convert.ToInt32(tbxSearchPCN.Text));
            if (p != null)
            {
                if(p is Teacher)
                {
                    ((Teacher)p).MakePromotion();
                    return;
                }
                MessageBox.Show("Only teachers can be promoted");
                
            }
            MessageBox.Show("No teacher found with supplied PCN");
        }

        private void btnPartialName_Click(object sender, EventArgs e)
        {
            lbxShowInfo.Items.Clear();
            foreach(Person p in admin.GetPerson())
            {
                if(p.GetName().Contains(txbPartialName.Text))
                {
                    lbxShowInfo.Items.Add(p);
                }
            }
        }

        private void rdbStudent_CheckedChanged(object sender, EventArgs e)
        {
            tbxECs.Enabled = teacherBox;
            teacherBox = !teacherBox;
            tbxSalary.Enabled = teacherBox;
        }
    }
}
