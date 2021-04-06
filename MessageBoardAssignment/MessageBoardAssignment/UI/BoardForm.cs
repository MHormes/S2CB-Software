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
    public partial class BoardForm : Form
    {
        TeacherManager TM;
        MessageManager MM;
        ChannelManager CM;
        public BoardForm(TeacherManager TM)
        {
            InitializeComponent();
            this.TM = TM;
            MM = new MessageManager();
            CM = new ChannelManager();
        }

        public void PopulateListbox(int currentClass)
        {
            listBox1.Items.Clear();
            foreach(Message m in MM.GetMessages(CM.GetCurrentChannel(currentClass)))
            {
                listBox1.Items.Add(m);
            }
        }
        private void btnGroep1_Click(object sender, EventArgs e)
        {
            PopulateListbox(1);
            if (TM.CurrentTeacher.ClassTeached != 1)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;   
        }

        private void btnGroep2_Click(object sender, EventArgs e)
        {
            PopulateListbox(2);
            if (TM.CurrentTeacher.ClassTeached != 2)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnGroep3_Click(object sender, EventArgs e)
        {
            PopulateListbox(3);
            if (TM.CurrentTeacher.ClassTeached != 3)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnGroep4_Click(object sender, EventArgs e)
        {
            PopulateListbox(4);
            if (TM.CurrentTeacher.ClassTeached != 4)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnGroep5_Click(object sender, EventArgs e)
        {
            PopulateListbox(5);
            if (TM.CurrentTeacher.ClassTeached != 5)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnGroep6_Click(object sender, EventArgs e)
        {
            PopulateListbox(6);
            if (TM.CurrentTeacher.ClassTeached != 6)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnGroep7_Click(object sender, EventArgs e)
        {
            PopulateListbox(7);
            if (TM.CurrentTeacher.ClassTeached != 7)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnGroep8_Click(object sender, EventArgs e)
        {
            PopulateListbox(8);
            if (TM.CurrentTeacher.ClassTeached != 8)
            {
                btnPostMessage.Enabled = false;
                tbxMessage.Enabled = false;
                return;
            }
            btnPostMessage.Enabled = true;
            tbxMessage.Enabled = true;
        }

        private void btnPostMessage_Click(object sender, EventArgs e)
        {
            Channel currentChannel = CM.GetCurrentChannel(TM.CurrentTeacher.ClassTeached);
            MM.PostMessage(tbxMessage.Text, TM.CurrentTeacher.FullName, currentChannel);
            PopulateListbox(TM.CurrentTeacher.ClassTeached);
            tbxMessage.Clear();
        }
    }
}
