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
        double startingPrice;
        public Form1()
        {
            TH = new TransportationHub("Borent");
            InitializeComponent();
            FillVehicleListboxes();
            FillRideListboxes();
            //Prepare add vehicle will be called when first launching the app
            PrepareAddVehicle();
            //start price for any ride can be adjusted here
            startingPrice = 10.50;
            lblStartingPrice.Text = $"Starting price of any ride: {startingPrice}";

            //STYLE DATETIMEPICKERS IN RIGHT FORMAT
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";

            //PRESELECT RADIOBUTTONS
            rbtnManualTime.Checked = true;
            rbtnPassengers.Checked = true;
        }


        //VEHICLES

        //METHOD TO FILL THE LISTBOXES OF VEHICLES
        public void FillVehicleListboxes()
        {
            lbxVehiclesAvailable.Items.Clear();
            lbxVehiclesAvailable.Items.Add("ALL AVAILABLE VEHICLES:");
            lbxVehiclesOnRide.Items.Clear();
            lbxVehiclesOnRide.Items.Add("ALL VEHICLES ON A RIDE:");

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

        //PREPARE TEXTBOXES FOR ADDING
        public void PrepareAddVehicle()
        {
            //enable/disable correct buttons and textfields
            btnConfirmAdd.Visible = true;
            btnAddVehicle.Visible = false;
            tbxTotalConsumedFuel.Enabled = false;
            tbxTotalKM.Enabled = false;
            tbxPricePerKM.Enabled = false;
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
            PrepareAddVehicle();
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

                //PREPARE TO ADD AGAIN
                PrepareAddVehicle();
                ClearVehicleTextBoxes();
            }
            catch (LicensePlateException lpEx)
            {
                MessageBox.Show(lpEx.Message);
            }
            catch (NoVehicleTypeSelectedException nvtsEx)
            {
                MessageBox.Show(nvtsEx.Message);
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
            if (lbxVehiclesAvailable.SelectedIndex == -1 || lbxVehiclesAvailable.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a available vehicle to edit");
                return;
            }

            //enable/disable correct buttons/textboxes
            tbxTotalConsumedFuel.Enabled = false;
            tbxTotalKM.Enabled = false;
            tbxPricePerKM.Enabled = false;
            btnEditSelected.Visible = false;
            btnConfirmEditVehicle.Visible = true;
            btnAddVehicle.Enabled = false;
            btnConfirmAdd.Enabled = false;
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

                //enable/disable correct buttons
                btnEditSelected.Visible = true;
                btnConfirmEditVehicle.Visible = false;
                btnConfirmAdd.Enabled = true;
                btnAddVehicle.Enabled = true;
                lbxVehiclesAvailable.Enabled = true;
                
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
            finally { }

        }


        //RIDES

        //METHOD TO FILL LISTBOXES OF RIDES
        public void FillRideListboxes()
        {
            lbxRidesInProgress.Items.Clear();
            lbxRidesInProgress.Items.Add("ALL RIDES STILL IN PROGRESS:");
            lbxRidesCompleted.Items.Clear();
            lbxRidesCompleted.Items.Add("ALL RIDES ALREADY COMPLETED:");

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

        //METHOD TO CLEAR RIDE TEXTBOXES
        public void ClearRideTextboxes()
        {
            tbxKMToTravel.Text = "";
            tbxAmountOfPassengers.Text = "";
            tbxWeightOfCargo.Text = "";
            tbxVolumeOfCargo.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }

        //Clears all textboxes
        private void btnClearRides_Click(object sender, EventArgs e)
        {
            ClearRideTextboxes();
        }

        //CONTROL TEXTBOXES ENABLE BASED ON RADIOBUTTON CHECK
        private void rbtnPassengers_CheckedChanged(object sender, EventArgs e)
        {
            tbxAmountOfPassengers.Enabled = rbtnPassengers.Checked;
            tbxVolumeOfCargo.Enabled = !rbtnPassengers.Checked;
            tbxWeightOfCargo.Enabled = !rbtnPassengers.Checked;
        }

        //CONTROL TIMEPICKERS ENABLE BASED ON RADIOBUTTON CHECK
        private void rbtnManualTime_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = rbtnManualTime.Checked;
            dtpEnd.Enabled = !rbtnAutomatictime.Checked;
        }

        //RESERVE RIDE AND ADD TO LISTBOX
        private void btnReserveRide_Click(object sender, EventArgs e)
        {
            int amountOfPassenger = 0;
            if (tbxAmountOfPassengers.Text != "")
            {
                amountOfPassenger = Convert.ToInt32(tbxAmountOfPassengers.Text);
            }
            double volumeOfCargo = 0;
            if (tbxVolumeOfCargo.Text != "")
            {
                volumeOfCargo = Convert.ToDouble(tbxVolumeOfCargo.Text);
            }
            double weightOfCargo = 0;
            if (tbxWeightOfCargo.Text != "")
            {
                weightOfCargo = Convert.ToDouble(tbxWeightOfCargo.Text);
            }

            bool forPassengers = true;
            if (rbtnCargo.Checked)
            {
                forPassengers = false;
            }

            DateTime? endTime = dtpEnd.Value;
            if (rbtnAutomatictime.Checked)
            {
                dtpStart.Value = DateTime.Now;
                endTime = null;
            }
            
            if (endTime < dtpStart.Value)
            {
                MessageBox.Show("End date must be after start date");
                return;
            }
            try
            {
                Vehicle v = TH.GetAvailableVehicle(forPassengers, amountOfPassenger, volumeOfCargo, weightOfCargo);
                if (v == null)
                {
                    MessageBox.Show("No available vehicle found for you reservation");
                    return;
                }
                TH.ReserveRide(v, amountOfPassenger, volumeOfCargo, weightOfCargo, 0, startingPrice, Convert.ToInt32(tbxKMToTravel.Text), dtpStart.Value, endTime);
                v.Available = false;
                FillRideListboxes();
                FillVehicleListboxes();
                ClearRideTextboxes();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //FINISH A RIDE AND GET A MESSAGE ABOUT THE TOTAL PRICE
        private void btnFinishRide_Click(object sender, EventArgs e)
        {
            if (lbxRidesInProgress.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a ride that had not yet been completed");
                return;
            }
            try
            {
                Ride r = (Ride)lbxRidesInProgress.SelectedItem;

                if (r.EndTime == null)
                {
                    r.EndTime = DateTime.Now;
                }
                r.Completed = true;
                r.Vehicle.Available = true; r.Vehicle.TotalKM += r.Kilometers; r.Vehicle.ConsumedFuel += r.Kilometers * Convert.ToDecimal(r.Vehicle.GasPerKM);
                double price = r.Vehicle.PricePerKM * r.Kilometers;
                r.PriceOfRide = price;
                MessageBox.Show($"You need to pay: {price.ToString("#.##")} Euro(s)");
                FillRideListboxes();
                FillVehicleListboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //GENERAL

        //SAVE ALL OBJECTS
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            //save vehicles
            if (TH.SaveAllVehicles() != null)
            {
                MessageBox.Show(TH.SaveAllVehicles().Message);
            }
            //save rides
            if (TH.SaveAllRides() != null)
            {
                MessageBox.Show(TH.SaveAllRides().Message);
            }

        }

        //LOAD ALL OBJECTS
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            //load vehicles
            if (TH.LoadAllVehicles() != null)
            {
                MessageBox.Show(TH.LoadAllVehicles().Message);
            }
            FillVehicleListboxes();

            //load rides
            if (TH.LoadAllRides() != null)
            {
                MessageBox.Show(TH.LoadAllRides().Message);
            }
            FillRideListboxes();


        }


    }
}
