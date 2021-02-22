using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Animal_Assignment
{
    public partial class Form1 : Form
    {
        private List<Animal> animals;

        public Form1()
        {
            animals = new List<Animal>();
            InitializeComponent();
           
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if(cbAnimalType.SelectedIndex == 0)
            {
                animals.Add(new Cat(tbName.Text));
            }
            else if(cbAnimalType.SelectedIndex == 1)
            {
                animals.Add(new Dog(tbName.Text));
            }
            else
            {
                animals.Add(new Duck(tbName.Text));
            }

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbAnimals.Items.Clear();
            foreach(Animal a in animals)
            {
                lbAnimals.Items.Add(a);
            }
        }

        private void btnMakeSound_Click(object sender, EventArgs e)
        {
            Animal a = null;
            foreach(Animal La in animals)
            {
                if(La == lbAnimals.SelectedItem)
                {
                    a = La;
                }
            }

            if(a is Cat)
            {
                MessageBox.Show(((Cat)a).speak());
            }
            else if(a is Dog)
            {
                MessageBox.Show(((Dog)a).speak());
            }
            else
            {
                MessageBox.Show(((Duck)a).speak());
            }
            
        }
    }
}
