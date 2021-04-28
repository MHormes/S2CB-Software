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
    partial class ToyCollectorForm : Form
    {
        WebshopLogic shop;
        public ToyCollectorForm(WebshopLogic getShop)
        {
            InitializeComponent();
            shop = getShop;
            shop.AddingProductEvent += new WebshopLogic.AddingNewProductHandler(AddToyToGUI);
            shop.UpdateProductEvent += new WebshopLogic.UpdateOldProductHandler(UpdateToyInGUI);
        }

        public void AddToyToGUI(Product product)
        {
            if(product.productType == ProductType.TOYS)
            {
                lbToys.Items.Add(product);
            }
        }

        public void UpdateToyInGUI(Product product)
        {
            if (lbToys.Items.Contains(product))
            {
                int target = lbToys.Items.IndexOf(product);
                lbToys.Items.RemoveAt(target);
                lbToys.Items.Insert(target, product);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Product product = (Product)lbToys.SelectedItem;
            if(shop.PurhcaseProduct(product, Convert.ToInt32(tbQuantity.Text)))
            {
                return;
            }
            MessageBox.Show("Product could not be bought.");

        }
    }
}
