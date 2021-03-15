using ModelsAndInterfaces;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUserDemo
{
    public partial class Form1 : Form
    {
        private UserService userService;

        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User u = userService.AddUser(new User(tbName.Text, tbEmail.Text));
            lbUser.Items.Add(u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbUser.Items.Add(userService.GetUserByName(tbName.Text));
        }
    }
}
