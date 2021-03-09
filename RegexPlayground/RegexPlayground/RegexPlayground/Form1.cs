using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace RegexPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidPhoneNumber_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(cbbInput.Text, "^06.?[1-9]{8}$"))
            {
                MessageBox.Show("This is a valid phone number");
                return;
            }
            MessageBox.Show("This is not a valid phone number");

        }

        private void btnDutchPhoneNumber_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cbbInput.Text, "^[+]31.?6.?[1-9]{8}$"))
            {
                MessageBox.Show("This is a valid dutch number");
                return;
            }
            MessageBox.Show("This is not a valid dutch number");
        }

        private void btnValidStreetname_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cbbInput.Text, "^[A-z. ]*$"))
            {
                MessageBox.Show("This is a valid street name");
                return;
            }
            MessageBox.Show("This is not a valid street name"); 
        }

        private void btnValidAddresss_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cbbInput.Text, "^[A-z. ]*[0-9]*[A-z]?$"))
            {
                MessageBox.Show("This is a valid street name");
                return;
            }
            MessageBox.Show("This is not a valid street name");
        }

        private void btnPatternCount_Click(object sender, EventArgs e)
        {
            MatchCollection matchCollection = Regex.Matches(tbxTestData.Text, cbbPattern.Text);
            MessageBox.Show("" + matchCollection.Count);
        }
    }
}
