
namespace TransportationHub_Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRide = new System.Windows.Forms.TabPage();
            this.tpVehicle = new System.Windows.Forms.TabPage();
            this.btnConfirmEditVehicle = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.tbxMaxVolume = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.tbxMaxWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMaxPassengers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxVehiclesAvailable = new System.Windows.Forms.ListBox();
            this.lbxVehiclesOnRide = new System.Windows.Forms.ListBox();
            this.btnClearInputVehicle = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.tbxTotalKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTotalConsumedFuel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPricePerKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxLicensePlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxGasPerKM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMakeAndModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeOfVehicle = new System.Windows.Forms.ComboBox();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRide);
            this.tabControl1.Controls.Add(this.tpVehicle);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRide
            // 
            this.tpRide.Location = new System.Drawing.Point(4, 22);
            this.tpRide.Name = "tpRide";
            this.tpRide.Padding = new System.Windows.Forms.Padding(3);
            this.tpRide.Size = new System.Drawing.Size(780, 598);
            this.tpRide.TabIndex = 0;
            this.tpRide.Text = "Rides";
            this.tpRide.UseVisualStyleBackColor = true;
            // 
            // tpVehicle
            // 
            this.tpVehicle.Controls.Add(this.btnConfirmEditVehicle);
            this.tpVehicle.Controls.Add(this.btnConfirmAdd);
            this.tpVehicle.Controls.Add(this.tbxMaxVolume);
            this.tpVehicle.Controls.Add(this.labelVolume);
            this.tpVehicle.Controls.Add(this.tbxMaxWeight);
            this.tpVehicle.Controls.Add(this.label9);
            this.tpVehicle.Controls.Add(this.tbxMaxPassengers);
            this.tpVehicle.Controls.Add(this.label10);
            this.tpVehicle.Controls.Add(this.lbxVehiclesAvailable);
            this.tpVehicle.Controls.Add(this.lbxVehiclesOnRide);
            this.tpVehicle.Controls.Add(this.btnClearInputVehicle);
            this.tpVehicle.Controls.Add(this.btnEditSelected);
            this.tpVehicle.Controls.Add(this.btnAddVehicle);
            this.tpVehicle.Controls.Add(this.tbxTotalKM);
            this.tpVehicle.Controls.Add(this.label7);
            this.tpVehicle.Controls.Add(this.tbxTotalConsumedFuel);
            this.tpVehicle.Controls.Add(this.label6);
            this.tpVehicle.Controls.Add(this.tbxPricePerKM);
            this.tpVehicle.Controls.Add(this.label5);
            this.tpVehicle.Controls.Add(this.tbxLicensePlate);
            this.tpVehicle.Controls.Add(this.label4);
            this.tpVehicle.Controls.Add(this.tbxGasPerKM);
            this.tpVehicle.Controls.Add(this.label3);
            this.tpVehicle.Controls.Add(this.tbxMakeAndModel);
            this.tpVehicle.Controls.Add(this.label2);
            this.tpVehicle.Controls.Add(this.label1);
            this.tpVehicle.Controls.Add(this.cbTypeOfVehicle);
            this.tpVehicle.Location = new System.Drawing.Point(4, 22);
            this.tpVehicle.Name = "tpVehicle";
            this.tpVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicle.Size = new System.Drawing.Size(780, 600);
            this.tpVehicle.TabIndex = 1;
            this.tpVehicle.Text = "Vehicles";
            this.tpVehicle.UseVisualStyleBackColor = true;
            // 
            // btnConfirmEditVehicle
            // 
            this.btnConfirmEditVehicle.Location = new System.Drawing.Point(6, 441);
            this.btnConfirmEditVehicle.Name = "btnConfirmEditVehicle";
            this.btnConfirmEditVehicle.Size = new System.Drawing.Size(119, 67);
            this.btnConfirmEditVehicle.TabIndex = 25;
            this.btnConfirmEditVehicle.Text = "Confirm edit available vehicle";
            this.btnConfirmEditVehicle.UseVisualStyleBackColor = true;
            this.btnConfirmEditVehicle.Visible = false;
            this.btnConfirmEditVehicle.Click += new System.EventHandler(this.btnConfirmEditVehicle_Click);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(6, 412);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(120, 23);
            this.btnConfirmAdd.TabIndex = 24;
            this.btnConfirmAdd.Text = "Confirm new vehicle";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Visible = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // tbxMaxVolume
            // 
            this.tbxMaxVolume.Location = new System.Drawing.Point(7, 386);
            this.tbxMaxVolume.Name = "tbxMaxVolume";
            this.tbxMaxVolume.Size = new System.Drawing.Size(121, 20);
            this.tbxMaxVolume.TabIndex = 9;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(7, 369);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(85, 13);
            this.labelVolume.TabIndex = 23;
            this.labelVolume.Text = "MaxVolume (m3)";
            // 
            // tbxMaxWeight
            // 
            this.tbxMaxWeight.Location = new System.Drawing.Point(7, 345);
            this.tbxMaxWeight.Name = "tbxMaxWeight";
            this.tbxMaxWeight.Size = new System.Drawing.Size(121, 20);
            this.tbxMaxWeight.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Max. weight (KG)";
            // 
            // tbxMaxPassengers
            // 
            this.tbxMaxPassengers.Location = new System.Drawing.Point(7, 305);
            this.tbxMaxPassengers.Name = "tbxMaxPassengers";
            this.tbxMaxPassengers.Size = new System.Drawing.Size(121, 20);
            this.tbxMaxPassengers.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Max. passengers";
            // 
            // lbxVehiclesAvailable
            // 
            this.lbxVehiclesAvailable.FormattingEnabled = true;
            this.lbxVehiclesAvailable.Location = new System.Drawing.Point(457, 7);
            this.lbxVehiclesAvailable.Name = "lbxVehiclesAvailable";
            this.lbxVehiclesAvailable.Size = new System.Drawing.Size(307, 589);
            this.lbxVehiclesAvailable.TabIndex = 18;
            // 
            // lbxVehiclesOnRide
            // 
            this.lbxVehiclesOnRide.FormattingEnabled = true;
            this.lbxVehiclesOnRide.Location = new System.Drawing.Point(151, 7);
            this.lbxVehiclesOnRide.Name = "lbxVehiclesOnRide";
            this.lbxVehiclesOnRide.Size = new System.Drawing.Size(300, 589);
            this.lbxVehiclesOnRide.TabIndex = 17;
            // 
            // btnClearInputVehicle
            // 
            this.btnClearInputVehicle.Location = new System.Drawing.Point(6, 514);
            this.btnClearInputVehicle.Name = "btnClearInputVehicle";
            this.btnClearInputVehicle.Size = new System.Drawing.Size(120, 23);
            this.btnClearInputVehicle.TabIndex = 16;
            this.btnClearInputVehicle.Text = "Clear all inputs";
            this.btnClearInputVehicle.UseVisualStyleBackColor = true;
            this.btnClearInputVehicle.Click += new System.EventHandler(this.btnClearInputVehicle_Click);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(7, 441);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(119, 67);
            this.btnEditSelected.TabIndex = 15;
            this.btnEditSelected.Text = "Edit selected available vehicle";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(6, 412);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(120, 23);
            this.btnAddVehicle.TabIndex = 14;
            this.btnAddVehicle.Text = "Add vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // tbxTotalKM
            // 
            this.tbxTotalKM.Location = new System.Drawing.Point(6, 266);
            this.tbxTotalKM.Name = "tbxTotalKM";
            this.tbxTotalKM.Size = new System.Drawing.Size(121, 20);
            this.tbxTotalKM.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total KM";
            // 
            // tbxTotalConsumedFuel
            // 
            this.tbxTotalConsumedFuel.Location = new System.Drawing.Point(6, 225);
            this.tbxTotalConsumedFuel.Name = "tbxTotalConsumedFuel";
            this.tbxTotalConsumedFuel.Size = new System.Drawing.Size(121, 20);
            this.tbxTotalConsumedFuel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total consumed fuel (Liters)";
            // 
            // tbxPricePerKM
            // 
            this.tbxPricePerKM.Location = new System.Drawing.Point(6, 185);
            this.tbxPricePerKM.Name = "tbxPricePerKM";
            this.tbxPricePerKM.Size = new System.Drawing.Size(121, 20);
            this.tbxPricePerKM.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price per km (Euro)";
            // 
            // tbxLicensePlate
            // 
            this.tbxLicensePlate.Location = new System.Drawing.Point(7, 104);
            this.tbxLicensePlate.Name = "tbxLicensePlate";
            this.tbxLicensePlate.Size = new System.Drawing.Size(121, 20);
            this.tbxLicensePlate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "License Plate";
            // 
            // tbxGasPerKM
            // 
            this.tbxGasPerKM.Location = new System.Drawing.Point(6, 144);
            this.tbxGasPerKM.Name = "tbxGasPerKM";
            this.tbxGasPerKM.Size = new System.Drawing.Size(121, 20);
            this.tbxGasPerKM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liters of gas per km";
            // 
            // tbxMakeAndModel
            // 
            this.tbxMakeAndModel.Location = new System.Drawing.Point(6, 62);
            this.tbxMakeAndModel.Name = "tbxMakeAndModel";
            this.tbxMakeAndModel.Size = new System.Drawing.Size(121, 20);
            this.tbxMakeAndModel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make and model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of vehicle";
            // 
            // cbTypeOfVehicle
            // 
            this.cbTypeOfVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfVehicle.FormattingEnabled = true;
            this.cbTypeOfVehicle.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Truck"});
            this.cbTypeOfVehicle.Location = new System.Drawing.Point(6, 23);
            this.cbTypeOfVehicle.Name = "cbTypeOfVehicle";
            this.cbTypeOfVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbTypeOfVehicle.TabIndex = 0;
            this.cbTypeOfVehicle.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfVehicle_SelectedIndexChanged);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(381, 645);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(396, 70);
            this.btnLoadAll.TabIndex = 29;
            this.btnLoadAll.Text = "Load all";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(23, 645);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(322, 70);
            this.btnSaveAll.TabIndex = 28;
            this.btnSaveAll.Text = "Save all ";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 741);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpVehicle.ResumeLayout(false);
            this.tpVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRide;
        private System.Windows.Forms.TabPage tpVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox tbxTotalKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTotalConsumedFuel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPricePerKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxLicensePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGasPerKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMakeAndModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeOfVehicle;
        private System.Windows.Forms.ListBox lbxVehiclesAvailable;
        private System.Windows.Forms.ListBox lbxVehiclesOnRide;
        private System.Windows.Forms.Button btnClearInputVehicle;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.TextBox tbxMaxVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox tbxMaxWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMaxPassengers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Button btnConfirmEditVehicle;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Button btnSaveAll;
    }
}

