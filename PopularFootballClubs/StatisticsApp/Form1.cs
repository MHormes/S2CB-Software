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

namespace StatisticsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;

            string filename;
            int firstCount = 0;
            int secondCount = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
            }
            else
            {
                MessageBox.Show("You choose cancel");
                return;
            }
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    if (s.Contains(tbxFirstClub.Text))
                    {
                        firstCount++;
                    }
                    else if (s.Contains(tbxSecondClub.Text))
                    {
                        secondCount++;
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
