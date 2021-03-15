using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationHub_Assignment
{
    public partial class Form1 : Form
    {
        TransportationHub TH;
        public Form1()
        {
            TH = new TransportationHub("Borent");
            InitializeComponent();
            FillVehicleListboxes();
        }

        //METHOD TO FILL THE LISTBOXES OF VEHICLES
        public void FillVehicleListboxes()
        {
            lbxVehiclesAvailable.Items.Clear();
            lbxVehiclesOnRide.Items.Clear();

            foreach (Vehicle v in TH.GetAllVehicles())
            {
                if (v.Available == true)
                {
                    lbxVehiclesAvailable.Items.Add(v);
                }
                else
                {
                    lbxVehiclesOnRide.Items.Add(v);
                }
            }
        }

        //METHOD TO CLEAR ALL TEXTBOXES
        private void ClearVehicleTextBoxes()
        {
            tbxGasPerKM.Text = "";
            tbxLicensePlate.Text = "";
            tbxMakeAndModel.Text = "";
            tbxMaxPassengers.Text = "";
            tbxMaxVolume.Text = "";
            tbxMaxWeight.Text = "";
            tbxPricePerKM.Text = "";
            tbxTotalConsumedFuel.Text = "";
            tbxTotalKM.Text = "";
            cbTypeOfVehicle.SelectedIndex = -1;
        }

        //CONTROLS TEXTBOX ENABLE FOR SELECTED INDEX OF CB
        private void cbTypeOfVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeOfVehicle.SelectedIndex == 0)
            {
                tbxMaxWeight.Enabled = false;
                tbxMaxVolume.Enabled = false;
                tbxMaxPassengers.Enabled = true;
            }
            else if (cbTypeOfVehicle.SelectedIndex == 1)
            {
                tbxMaxWeight.Enabled = true;
                tbxMaxVolume.Enabled = true;
                tbxMaxPassengers.Enabled = true;
            }
            else
            {
                tbxMaxWeight.Enabled = true;
                tbxMaxVolume.Enabled = true;
                tbxMaxPassengers.Enabled = false;
            }
        }

        //CLEAR ALL VEHICLE TEXTBOXES
        private void btnClearInputVehicle_Click(object sender, EventArgs e)
        {
            ClearVehicleTextBoxes();
        }

        //PREPARE ADD VEHICLE BUTTON
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            btnConfirmAdd.Visible = true;
            btnAddVehicle.Visible = false;
            tbxTotalConsumedFuel.Enabled = false;
            tbxTotalKM.Enabled = false;
            tbxPricePerKM.Enabled = false;
            ClearVehicleTextBoxes();
        }

        //CONFIRM ADDING VEHICLE BUTTON
        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            foreach(Vehicle v in TH.GetAllVehicles())
            {
                if(v.LicensePlate == tbxLicensePlate.Text)
                {
                    MessageBox.Show("Licenseplate is already registered");
                    return;
                }
            }

            try
            {
                int maxPassengers = 0;
                if (tbxMaxPassengers.Text != "")
                {
                    maxPassengers = Convert.ToInt32(tbxMaxPassengers.Text);
                }
                double maxWeight = 0;
                if (tbxMaxWeight.Text != "")
                {
                    maxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                }

                double maxVolume = 0;
                if (tbxMaxWeight.Text != "")
                {
                    maxVolume = Convert.ToDouble(tbxMaxWeight.Text);
                }

                TH.AddVehicle(cbTypeOfVehicle.SelectedIndex, maxPassengers, maxWeight, maxVolume, tbxMakeAndModel.Text, tbxLicensePlate.Text, Convert.ToDouble(tbxGasPerKM.Text));
                FillVehicleListboxes();
                btnAddVehicle.Visible = true;
                btnConfirmAdd.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //PREPARE EDIT VEHICLE BUTTON
        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (lbxVehiclesAvailable.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle to edit");
                return;
            }

            tbxTotalConsumedFuel.Enabled = false;
            tbxTotalKM.Enabled = false;
            tbxPricePerKM.Enabled = false;

            btnEditSelected.Visible = false;
            btnConfirmEditVehicle.Visible = true;
            Vehicle v = (Vehicle)lbxVehiclesAvailable.SelectedItem;
            lbxVehiclesAvailable.Enabled = false;
            if (v is Car)
            {
                cbTypeOfVehicle.SelectedIndex = 0;
                tbxMaxPassengers.Text = $"{((Car)v).MaxPassenger}";
            }
            else if (v is Van)
            {
                cbTypeOfVehicle.SelectedIndex = 1;
                tbxMaxPassengers.Text = $"{((Van)v).MaxPassenger}";
                tbxMaxVolume.Text = $"{((Van)v).MaxVolume}";
                tbxMaxWeight.Text = $"{((Van)v).MaxWeight}";
            }
            else
            {
                cbTypeOfVehicle.SelectedIndex = 2;
                tbxMaxVolume.Text = $"{((Truck)v).MaxVolume}";
                tbxMaxWeight.Text = $"{((Truck)v).MaxWeight}";
            }

            tbxMakeAndModel.Text = v.MakeAndModel;
            tbxLicensePlate.Text = v.LicensePlate;
            tbxGasPerKM.Text = $"{v.GasPerKM}";
            tbxPricePerKM.Text = $"{v.PricePerKM}";
            tbxTotalConsumedFuel.Text = $"{v.ConsumedFuel}";
            tbxTotalKM.Text = $"{v.TotalKM}";

        }

        //CONFIRM EDIT SELECTED VEHICLE
        private void btnConfirmEditVehicle_Click(object sender, EventArgs e)
        {

            try
            {
                Vehicle v = (Vehicle)lbxVehiclesAvailable.SelectedItem;
               
                btnEditSelected.Visible = true;
                btnConfirmEditVehicle.Visible = false;
                v.MakeAndModel = tbxMakeAndModel.Text;
                v.LicensePlate = tbxLicensePlate.Text;
                v.GasPerKM = Convert.ToDouble(tbxGasPerKM.Text);
                v.PricePerKM = 100 / Convert.ToDouble(tbxGasPerKM.Text);
                v.ConsumedFuel = (decimal)(v.TotalKM * Convert.ToDouble(tbxGasPerKM.Text));

                if (v is Car)
                {
                    ((Car)v).MaxPassenger = Convert.ToInt32(tbxMaxPassengers.Text);
                }
                else if (v is Van)
                {
                    ((Van)v).MaxPassenger = Convert.ToInt32(tbxMaxPassengers.Text);
                    ((Van)v).MaxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                    ((Van)v).MaxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                }
                else
                {
                    ((Truck)v).MaxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                    ((Truck)v).MaxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                }

                FillVehicleListboxes();
                lbxVehiclesAvailable.SelectedIndex = -1;
                ClearVehicleTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { lbxVehiclesAvailable.Enabled = true; }

        }

        //SAVE ALL OBJECTS
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (TH.SaveAllVehicles() == null)
            {
                return;
            }
            MessageBox.Show(TH.SaveAllVehicles().Message);
        }

        //LOAD ALL OBJECTS
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            if (TH.LoadAllVehicles() == null)
            {
                FillVehicleListboxes();

                return;
            }
            MessageBox.Show(TH.LoadAllVehicles().Message);

        }
    }
}
