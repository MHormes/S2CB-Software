using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            FillRideListboxes();
        }


        //VEHICLES

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

        //CONTROLS TEXTBOX ENABLE FOR SELECTED INDEX OF Combobox vehicle type
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
            //enable/disable correct buttons and textfields
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
            //check if licenseplate already exists
            foreach (Vehicle v in TH.GetAllVehicles())
            {
                if (v.LicensePlate == tbxLicensePlate.Text)
                {
                    MessageBox.Show("Licenseplate is already registered");
                    return;
                }
            }

            try
            {
                //check if textboxes are filled in and assign value (needed since not al vehicle types use all texboxes)
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
                    maxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                }
                TH.AddVehicle(cbTypeOfVehicle.SelectedIndex, maxPassengers, maxWeight, maxVolume, tbxMakeAndModel.Text, tbxLicensePlate.Text, Convert.ToDouble(tbxGasPerKM.Text));
                FillVehicleListboxes();
                btnAddVehicle.Visible = true;
                btnConfirmAdd.Visible = false;

            }
            catch (LicensePlateException lpEx)
            {
                MessageBox.Show(lpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //PREPARE EDIT VEHICLE BUTTON
        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            //check if vehicle is selected
            if (lbxVehiclesAvailable.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle to edit");
                return;
            }

            //enable/disable correct buttons/textboxes
            tbxTotalConsumedFuel.Enabled = false;
            tbxTotalKM.Enabled = false;
            tbxPricePerKM.Enabled = false;
            btnEditSelected.Visible = false;
            btnConfirmEditVehicle.Visible = true;
            lbxVehiclesAvailable.Enabled = false;

            //Assign selected -> check what type of vehicle -> fill in textboxes with existing data
            Vehicle v = (Vehicle)lbxVehiclesAvailable.SelectedItem;
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
            tbxPricePerKM.Text = v.PricePerKM.ToString("#.##");
            tbxTotalConsumedFuel.Text = v.ConsumedFuel.ToString("#.##");
            tbxTotalKM.Text = $"{v.TotalKM}";
        }

        //CONFIRM EDIT SELECTED VEHICLE
        private void btnConfirmEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                //enable/disable correct buttons
                btnEditSelected.Visible = true;
                btnConfirmEditVehicle.Visible = false;

                //get correct object and update data via properties
                Vehicle v = (Vehicle)lbxVehiclesAvailable.SelectedItem;
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
            catch (LicensePlateException lpEx)
            {
                MessageBox.Show(lpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { lbxVehiclesAvailable.Enabled = true; }

        }


        //RIDES

        //METHOD TO FILL LISTBOXES OF RIDES
        public void FillRideListboxes()
        {
            lbxRidesInProgress.Items.Clear();
            lbxRidesCompleted.Items.Clear();

            foreach (Ride r in TH.GetAllRides())
            {
                if (r.Completed == true)
                {
                    lbxRidesCompleted.Items.Add(r);
                }
                else
                {
                    lbxRidesInProgress.Items.Add(r);
                }
            }
        }

        //CONTROL TEXTBOXES ENABLE BASED ON RADIOBUTTON CHECK
        private void rbtnPassengers_CheckedChanged(object sender, EventArgs e)
        {
            tbxAmountOfPassengers.Enabled = rbtnPassengers.Checked;
            tbxVolumeOfCargo.Enabled = !rbtnPassengers.Checked;
            tbxWeightOfCargo.Enabled = !rbtnPassengers.Checked;
        }

        //GENERAL

        //SAVE ALL OBJECTS
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            //save vehicles
            if (TH.SaveAllVehicles() == null)
            {
                return;
            }
            MessageBox.Show(TH.SaveAllVehicles().Message);
        }

        //LOAD ALL OBJECTS
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            //load vehicles
            if (TH.LoadAllVehicles() == null)
            {
                FillVehicleListboxes();

                return;
            }
            MessageBox.Show(TH.LoadAllVehicles().Message);

        }


    }
}
