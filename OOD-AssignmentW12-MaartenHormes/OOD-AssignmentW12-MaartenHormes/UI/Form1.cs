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

        //Button click for updating the selected workshop
        private void btnUpdateWorkshop_Click(object sender, EventArgs e)
        {
            //create temp object to save the name of workshop before the edit
            IWorkshop workshopToEdit = (IWorkshop)lbxAvailableWorkshops.SelectedItem;  
            WM.UpdateWorkshop(workshopToEdit.Name, tbxWorkshopName.Text, tbxWorkshopDescription.Text, tbxMaxCapacity.Text, dtpWorkshopDate.Value, tbxWorkshopURL.Text, tbxWorkshopAdress.Text, tbxWorkshopRoomNmr.Text);
            UpdateWorkshopListbox();
            
            //Enable radiobuttons
            rbWorkshopOnline.Enabled = true;
            rbWorkshopInBuilding.Enabled = true;
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

        //Method for filling textboxes when user selects workshop from the listbox
        private void lbxAvailableWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disable Radiobuttons
            rbWorkshopInBuilding.Enabled = false;
            rbWorkshopOnline.Enabled = false;

            //Check if something is selected
            if (lbxAvailableWorkshops.SelectedIndex != -1)
            {
                //Create temp object and fill boxes
                IWorkshop workshop = (IWorkshop)lbxAvailableWorkshops.SelectedItem;
                tbxWorkshopName.Text = workshop.Name;
                tbxWorkshopDescription.Text = workshop.Description;
                tbxMaxCapacity.Text = workshop.MaxCapacity.ToString();

                //fill boxes for adress and url based on the type of IWorkshop
                if (workshop is WorkshopInBuilding)
                {
                    tbxWorkshopAdress.Text = ((WorkshopInBuilding)workshop).Adress;
                    tbxWorkshopRoomNmr.Text = ((WorkshopInBuilding)workshop).RoomNmr.ToString();
                    rbWorkshopInBuilding.Checked = true;
                    return;
                }
                tbxWorkshopURL.Text = ((WorkshopOnline)workshop).URL;
                rbWorkshopOnline.Checked = true;
            }
        }
    }
}
