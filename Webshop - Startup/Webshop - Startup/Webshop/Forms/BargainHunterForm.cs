using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop
{
    partial class BargainHunterForm : Form
    {
        WebshopLogic shop;
        double maxPrice;
        public BargainHunterForm(WebshopLogic getShop)
        {
            InitializeComponent();
            shop = getShop;
            shop.AddingProductEvent += new WebshopLogic.AddingNewProductHandler(AddToyToGUI);
            shop.UpdateProductEvent += new WebshopLogic.UpdateOldProductHandler(UpdateToyInGUI);
        }

        public void AddToyToGUI(Product product)
        {
            if (product.Price <= maxPrice)
            {
                lbBargains.Items.Add(product);
            }
        }

        public void UpdateToyInGUI(Product product)
        {
            if (lbBargains.Items.Contains(product))
            {
                int target = lbBargains.Items.IndexOf(product);
                lbBargains.Items.RemoveAt(target);
                lbBargains.Items.Insert(target, product);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            maxPrice = Convert.ToDouble(tbPriceLimit.Text);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Product product = (Product)lbBargains.SelectedItem;
            if (shop.PurhcaseProduct(product, Convert.ToInt32(tbQuantity.Text)))
            {
                return;
            }
            MessageBox.Show("Product could not be bought.");
        }
    }
}
