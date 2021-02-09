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
        public Form1()
        {
            InitializeComponent();
            admin = new Administration();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            if (admin.AlreadyExcists(Convert.ToInt32(tbxPCN.Text)))
            {
                MessageBox.Show("Someone already has this pcn");
                return;
            }
            Person nP = new Person(Convert.ToInt32(tbxAge.Text), tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxYearsAtSchool.Text));
            admin.AddPerson(nP);
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            if (admin.AlreadyExcists(Convert.ToInt32(tbxPCN.Text)))
            {
                MessageBox.Show("Someone already has this pcn");
                return;
            }
            Student nS = new Student(Convert.ToInt32(tbxAge.Text), tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxYearsAtSchool.Text));
            admin.AddStudent(nS);
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            if (admin.AlreadyExcists(Convert.ToInt32(tbxPCN.Text)))
            {
                MessageBox.Show("Someone already has this pcn");
                return;
            }
            Teacher nT = new Teacher(Convert.ToInt32(tbxAge.Text), tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxYearsAtSchool.Text));
            admin.AddTeacher(nT);
        }

        private void btnShowAllPerson_Click(object sender, EventArgs e)
        {
            lbxShowInfo.Items.Clear();
            foreach(Person p in admin.GetPerson())
            {
                lbxShowInfo.Items.Add(p); ;
            }
        }

        private void btnShowInfoPerson_Click(object sender, EventArgs e)
        {
            if(admin.GetPerson(Convert.ToInt32(tbxShowPerson.Text)) != null)
            {
                lbxShowInfo.Items.Clear();
                lbxShowInfo.Items.Add(admin.GetPerson(Convert.ToInt32(tbxShowPerson.Text)));
                return;
            }
            MessageBox.Show("No person found with supplied PCN");
        }

        private void btnShowAllStudent_Click(object sender, EventArgs e)
        {
            lbxShowInfo.Items.Clear();
            foreach(Student s in admin.GetStudents())
            {
                lbxShowInfo.Items.Add(s);
            }
        }

        private void btnShowInfoStudent_Click(object sender, EventArgs e)
        {
            if (admin.GetStudent(Convert.ToInt32(tbxShowStudent.Text)) != null)
            {
                lbxShowInfo.Items.Clear();
                lbxShowInfo.Items.Add(admin.GetStudent(Convert.ToInt32(tbxShowStudent.Text)));
                return;
            }
            MessageBox.Show("No student found with supplied PCN");
        }

        private void btnStartNewYear_Click(object sender, EventArgs e)
        {
            Student s = admin.GetStudent(Convert.ToInt32(tbxShowStudent.Text));
            if (s != null)
            {
                s.StartAnotherSchoolyear();
                return;
            }
            MessageBox.Show("No student found with supplied PCN");
        }

        private void btnAddECs_Click(object sender, EventArgs e)
        {
            Student s = admin.GetStudent(Convert.ToInt32(tbxShowStudent.Text));
            if (s != null)
            {
                s.AddECs(Convert.ToInt32(tbxAddECs.Text));
                return;
            }
            MessageBox.Show("No student found with supplied PCN");
        }

        private void btnShowAllTeacher_Click(object sender, EventArgs e)
        {
            lbxShowInfo.Items.Clear();
            foreach (Teacher t in admin.GetTeachers())
            {
                lbxShowInfo.Items.Add(t);
            }
        }

        private void btnShowInfoTeacher_Click(object sender, EventArgs e)
        {
            Teacher t = admin.GetTeacher(Convert.ToInt32(tbxShowTeacher.Text));
            if (t != null)
            {
                lbxShowInfo.Items.Clear();
                lbxShowInfo.Items.Add(t);
                return;
            }
            MessageBox.Show("No teacher found with supplied PCN");
        }

        private void btnStartNewSchoolYearTeach_Click(object sender, EventArgs e)
        {
            Teacher t = admin.GetTeacher(Convert.ToInt32(tbxShowTeacher.Text));
            if (t != null)
            {
                t.StartAnotherSchoolyear();
                return;
            }
            MessageBox.Show("No teacher found with supplied PCN");
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            Teacher t = admin.GetTeacher(Convert.ToInt32(tbxShowTeacher.Text));
            if (t != null)
            {
                t.MakePromotion();
                return;
            }
            MessageBox.Show("No teacher found with supplied PCN");
        }
    }
}
