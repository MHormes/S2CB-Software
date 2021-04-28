using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataCollectingApp;

namespace StatisticsApp
{
    public partial class Form1 : Form
    {
        VoteSaver VS;
        public Form1()
        {
            InitializeComponent();
            VS = new VoteSaver();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                VS.CompareVotes(tbxFirstClub.Text, tbxSecondClub.Text, filename);
                label2.Text = VS.GetTeam1Votes().ToString();
                label3.Text = VS.GetTeam2Votes().ToString();
            }
            else
            {
                MessageBox.Show("You choose cancel");
                return;
            }
        }
    }
}
