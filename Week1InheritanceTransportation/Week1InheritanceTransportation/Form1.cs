using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1InheritanceTransportation
{
    public partial class Form1 : Form
    {

        TransportationManager tm = new TransportationManager();

        public Form1()
        {
            InitializeComponent();

            tm.AddTransportation(new Car("123", "red", 220));
            tm.AddTransportation(new Car("234", "red", 225));
            tm.AddTransportation(new Car("987", "blue", 350));
            tm.AddTransportation(new Car("357", "black", 120));
            tm.AddTransportation(new Car("101", "gray", 300));

            tm.AddTransportation(new Boat("Navy", 3, 8));
            tm.AddTransportation(new Boat("Columb", 5, 6));
            tm.AddTransportation(new Boat("Sea", 4, 7));

            foreach(Transportation t in tm.GetTransportations())
            {
                listBox1.Items.Add(t);
            }

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Transportation t = (Transportation)listBox1.SelectedItem;

            if(t is Car)
            {
                label1.Text = ((Car)t).ToString();
            }

            if(t is Boat)
            {
                label1.Text = ((Boat)t).ToString();
            }
        }
    }
}
