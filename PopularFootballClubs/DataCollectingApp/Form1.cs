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

namespace DataCollectingApp
{
    public partial class Form1 : Form
    {
        string cityName;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetCityName_Click(object sender, EventArgs e)
        {
            cityName = tbxCity.Text;
            this.Text = cityName;
            this.pnlGold.Visible = false;
            this.pnlRed.Dock = DockStyle.Fill;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream($"votesFrom{cityName}", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(tbxFavoriteClubs.Text);
                tbxFavoriteClubs.Clear();1
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                
            }
        }
    }
}
