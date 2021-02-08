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

            tm.AddCar(new Car("123", "red", 220));
            tm.AddCar(new Car("234", "red", 225));
            tm.AddCar(new Car("987", "blue", 350));
            tm.AddCar(new Car("357", "black", 120));
            tm.AddCar(new Car("101", "gray", 300));

            tm.AddBoat(new Boat("Navy", 3, 8));
            tm.AddBoat(new Boat("Columb", 5, 6));
            tm.AddBoat(new Boat("Sea", 4, 7));

            foreach(Car c in tm.GetCars())
            {
                listBox1.Items.Add(c);
            }

            foreach(Boat b in tm.GetBoats())
            {
                listBox1.Items.Add(b);
            }
        }
    }
}
