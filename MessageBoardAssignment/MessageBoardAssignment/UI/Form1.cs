using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoardAssignment
{
    public partial class Form1 : Form
    {
        TeacherManager TM;
        public Form1()
        {
            InitializeComponent();
            TM = new TeacherManager();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(TM.SetCurrentTeacher(tbxTeacherName.Text, tbxTeachedClass.Text))
            {
                BoardForm BF = new BoardForm(TM);
                this.Hide();
                BF.Show();                
            }
            else
            {
                MessageBox.Show("Login was unsuccessfull");
            }
        }
    }
}
