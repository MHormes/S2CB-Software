using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentAnimals
{
    public partial class Form1 : Form
    {
        Turtle nT;
        public Form1()
        {
            nT = new Turtle("Piet", 12);
            InitializeComponent();

            nT.CelebrateBirthday();
        }
    }
}
