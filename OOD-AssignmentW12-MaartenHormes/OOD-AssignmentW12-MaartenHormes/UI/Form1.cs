using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_AssignmentW12_MaartenHormes
{
    public partial class Form1 : Form
    {
        WorkshopManager WM;
        bool selectedBuilding = true;
        public Form1()
        {
            InitializeComponent();
            WM = new WorkshopManager();
            rbWorkshopInBuilding.Checked = true;
        }

        //Button click for creating a new workshop
        private void btnCreateWorkshop_Click(object sender, EventArgs e)
        {
            WM.CreateNewWorkshop(rbWorkshopInBuilding.Checked, tbxWorkshopName.Text, tbxWorkshopDescription.Text, tbxMaxCapacity.Text, dtpWorkshopDate.Value, tbxWorkshopURL.Text, tbxWorkshopAdress.Text, tbxWorkshopRoomNmr.Text);
            UpdateWorkshopListbox();
        }



        //METHODS FOR UPDATING GUI ON USER INPUT

        //Enable/Disable textboxes for adding workshop based on the type of workshop to add
        private void rbWorkshopInBuilding_CheckedChanged(object sender, EventArgs e)
        {
            tbxWorkshopURL.Visible = !selectedBuilding;
            label5.Visible = !selectedBuilding;

            tbxWorkshopRoomNmr.Visible = selectedBuilding;
            tbxWorkshopAdress.Visible = selectedBuilding;
            label6.Visible = selectedBuilding;

            selectedBuilding = !selectedBuilding;
        }

        //Method to call for refreshing the listbox with all workshops
        public void UpdateWorkshopListbox()
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach(IWorkshop workshop in WM.GetWorkshops())
            {
                lbxAvailableWorkshops.Items.Add(workshop);
            }
        }
        
    }
}
