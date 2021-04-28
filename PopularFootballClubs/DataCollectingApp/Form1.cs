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
        VoteSaver VS;
        public Form1()
        {
            InitializeComponent();
            VS = new VoteSaver();
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
            var Save = VS.SaveVote(tbxFavoriteClubs.Text, cityName);
            if(Save == null)
            {
                return;
            }
            MessageBox.Show(Save.Message);
            tbxFavoriteClubs.Text = "";
        }
    }
}
