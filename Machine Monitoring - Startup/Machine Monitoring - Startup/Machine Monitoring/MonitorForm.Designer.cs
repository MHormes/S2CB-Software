namespace Machine_Monitoring
{
    partial class MonitorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.btnSimTemperature = new System.Windows.Forms.Button();
            this.btnSimPressure = new System.Windows.Forms.Button();
            this.btnToggleLogging = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbWarnings = new System.Windows.Forms.ListBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.tbPressure);
            this.groupBox1.Controls.Add(this.tbTemperature);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMachineName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(236, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Data";
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(99, 65);
            this.tbPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(125, 20);
            this.tbPressure.TabIndex = 6;
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(99, 41);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(125, 20);
            this.tbTemperature.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature";
            // 
            // tbMachineName
            // 
            this.tbMachineName.Location = new System.Drawing.Point(99, 17);
            this.tbMachineName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(125, 20);
            this.tbMachineName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of machine";
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(251, 11);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(206, 21);
            this.btnAddMachine.TabIndex = 2;
            this.btnAddMachine.Text = "Add Machine";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // btnSimTemperature
            // 
            this.btnSimTemperature.Location = new System.Drawing.Point(251, 36);
            this.btnSimTemperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimTemperature.Name = "btnSimTemperature";
            this.btnSimTemperature.Size = new System.Drawing.Size(206, 21);
            this.btnSimTemperature.TabIndex = 3;
            this.btnSimTemperature.Text = "Simulate temperature data from machine";
            this.btnSimTemperature.UseVisualStyleBackColor = true;
            this.btnSimTemperature.Click += new System.EventHandler(this.btnSimTemperature_Click);
            // 
            // btnSimPressure
            // 
            this.btnSimPressure.Location = new System.Drawing.Point(251, 61);
            this.btnSimPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimPressure.Name = "btnSimPressure";
            this.btnSimPressure.Size = new System.Drawing.Size(206, 21);
            this.btnSimPressure.TabIndex = 4;
            this.btnSimPressure.Text = "Simulate pressure data from machine";
            this.btnSimPressure.UseVisualStyleBackColor = true;
            this.btnSimPressure.Click += new System.EventHandler(this.btnSimPressure_Click);
            // 
            // btnToggleLogging
            // 
            this.btnToggleLogging.Location = new System.Drawing.Point(461, 11);
            this.btnToggleLogging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToggleLogging.Name = "btnToggleLogging";
            this.btnToggleLogging.Size = new System.Drawing.Size(90, 21);
            this.btnToggleLogging.TabIndex = 5;
            this.btnToggleLogging.Text = "Start logging";
            this.btnToggleLogging.UseVisualStyleBackColor = true;
            this.btnToggleLogging.Click += new System.EventHandler(this.btnToggleLogging_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(461, 36);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 21);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load from file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(461, 61);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 21);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Coral;
            this.groupBox2.Controls.Add(this.lbWarnings);
            this.groupBox2.Controls.Add(this.lbInfo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 228);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // lbWarnings
            // 
            this.lbWarnings.FormattingEnabled = true;
            this.lbWarnings.Location = new System.Drawing.Point(313, 32);
            this.lbWarnings.Name = "lbWarnings";
            this.lbWarnings.Size = new System.Drawing.Size(219, 186);
            this.lbWarnings.TabIndex = 3;
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(9, 32);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(298, 186);
            this.lbInfo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Warnings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company and Machines";
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(563, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnToggleLogging);
            this.Controls.Add(this.btnSimPressure);
            this.Controls.Add(this.btnSimTemperature);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddMachine);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MonitorForm";
            this.Text = "Monitoring";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimTemperature;
        private System.Windows.Forms.Button btnSimPressure;
        private System.Windows.Forms.Button btnToggleLogging;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbWarnings;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMachineName;
    }
}

