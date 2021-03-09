using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class BakeryForm : Form
    {
        Bakery bakery;
        Bread CurrentBread;
        Sandwich newSandwich;
        public BakeryForm()
        {
            InitializeComponent();
            FillBreadTypesComboBox();
            FillIngredientsCombobox();
            bakery = new Bakery("Joon");
        }

        public void FillBreadTypesComboBox()
        {
            List<Bread> breadTypes = new List<Bread>();
            breadTypes.Add(new Bread("Ciabatta", BreadType.CIABATTA, 3));
            breadTypes.Add(new Bread("Whole Wheat", BreadType.WHOLEWHEAT, 2));
            breadTypes.Add(new Bread("Rye", BreadType.RYE, 2.5));
            breadTypes.Add(new Bread("Sour Dough", BreadType.SOURDOUGH, 3.5));
            breadTypes.Add(new Bread("Focaccia", BreadType.FOCACCIA, 3.25));
            cbBreadTypes.DataSource = breadTypes;
            cbBreadTypes.DisplayMember = "Description";
        }

        public void FillIngredientsCombobox()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient("Cucumber", IngredientType.VEGETABLE, 0.05));
            ingredients.Add(new Ingredient("Tomato", IngredientType.VEGETABLE, 0.15));
            ingredients.Add(new Ingredient("Cheddar", IngredientType.CHEESE, 0.2));
            ingredients.Add(new Ingredient("Ham", IngredientType.MEAT, 0.15));
            ingredients.Add(new Ingredient("Chorizo", IngredientType.MEAT, 0.25));
            ingredients.Add(new Ingredient("Apple", IngredientType.FRUIT, 0.1));
            ingredients.Add(new Ingredient("Tuna", IngredientType.FISH, 0.2));
            ingredients.Add(new Ingredient("Smoked Salmon", IngredientType.FISH, 0.4));
            ingredients.Add(new Ingredient("Cream cheese", IngredientType.CHEESE, 0.15));
            ingredients.Add(new Ingredient("Gouda cheese", IngredientType.CHEESE, 0.1));
            cbIngredients.DataSource = ingredients;
            cbIngredients.DisplayMember = "Description";
        }

        private void btAddBread_Click(object sender, EventArgs e)
        {
            foreach(Sandwich s in bakery.sandwiches)
            {
                if(s.Name == tbName.Text)
                {
                    MessageBox.Show("Sandwich name already in use");
                    return;
                }
            }
            try
            {
                BreadType test = (BreadType)cbBreadTypes.SelectedIndex;
                double price = (double)cbBreadTypes.SelectedIndex;
                CurrentBread = (Bread)cbBreadTypes.SelectedItem;
                newSandwich = new Sandwich(tbName.Text, CurrentBread);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddIngredient_Click(object sender, EventArgs e)
        {
            bool moreThen5 = true;
            if(!newSandwich.AddIngredient((Ingredient)cbIngredients.SelectedItem, out moreThen5))
            {
                MessageBox.Show("Ingredient could not be added");
            }
            
        }

        private void btSandwichFinished_Click(object sender, EventArgs e)
        {
            bakery.sandwiches.Add(newSandwich);
            lbSandwiches.Items.Clear();

            foreach  (Sandwich sw in bakery.sandwiches)
            {
                lbSandwiches.Items.Add(sw.NameAndPrice);
            }
        }

        private void lbSandwiches_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sandwich currentSandwich = null;
            foreach(Sandwich sw in bakery.sandwiches)
            {
                if((String)lbSandwiches.SelectedItem == sw.NameAndPrice)
                {
                    currentSandwich = sw;
                }
            }

            lblSandwichNameAndPrice.Text = currentSandwich.NameAndPrice;

            string ingredients = "";
            foreach(Ingredient i in currentSandwich.ingredients)
            {
                ingredients += i.Description;
            }
            lblIngredients.Text = ingredients;
        }

        private void btCreatePriceList_Click(object sender, EventArgs e)
        {
            bakery.CreatePriceList();
        }

        private void btSaveSandwiches_Click(object sender, EventArgs e)
        {
            bakery.SaveSandwiches();
        }

        private void btLoadSandwiches_Click(object sender, EventArgs e)
        {
            foreach (Sandwich sw in bakery.LoadSandwiches())
            {
                lbSandwiches.Items.Add(sw.NameAndPrice);
            }
        }
    }
}
