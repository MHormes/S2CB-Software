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
    partial class WebshopForm : Form
    {
        WebshopLogic shop;
        public WebshopForm()
        {
            InitializeComponent();
            shop = new WebshopLogic();
            ToyCollectorForm toyF = new ToyCollectorForm(shop);
            toyF.Show();
            BargainHunterForm barF = new BargainHunterForm(shop);
            barF.Show();

            cbProductType.DataSource = Enum.GetValues(typeof(ProductType));
        }

        private void UpdateGUI()
        {
            lbProducts.Items.Clear();
            foreach(Product p in shop.GetProducts())
            {
                lbProducts.Items.Add(p);
            }
        }

        private void WebshopForm_Activated(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addNewProduct = shop.AddNewProduct(tbName.Text, tbPrice.Text, (ProductType)cbProductType.SelectedItem, tbStock.Text);
            if(addNewProduct == null)
            {
                UpdateGUI();
                return;
            }
            MessageBox.Show(addNewProduct.Message);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product pToUpdate = (Product)lbProducts.SelectedItem;
            var editOldProduct = shop.EditOldProduct(pToUpdate, tbName.Text, tbPrice.Text, (ProductType)cbProductType.SelectedItem, tbStock.Text);
            if(editOldProduct == null)
            {
                UpdateGUI();
                return;
            }
            MessageBox.Show(editOldProduct.Message);
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product pToUpdate = (Product)lbProducts.SelectedItem;
            tbName.Text = pToUpdate.Name;
            tbPrice.Text = pToUpdate.Price.ToString();
            tbStock.Text = pToUpdate.Stock.ToString();

            cbProductType.SelectedItem = pToUpdate.productType;
        }
    }
}
