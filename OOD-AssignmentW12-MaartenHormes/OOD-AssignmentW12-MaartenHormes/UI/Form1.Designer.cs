
namespace OOD_AssignmentW12_MaartenHormes
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
            this.tpWorkshop = new System.Windows.Forms.TabPage();
            this.btnCreateWorkshop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxWorkshopRoomNmr = new System.Windows.Forms.TextBox();
            this.tbxWorkshopAdress = new System.Windows.Forms.TextBox();
            this.tbxWorkshopURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbWorkshopOnline = new System.Windows.Forms.RadioButton();
            this.rbWorkshopInBuilding = new System.Windows.Forms.RadioButton();
            this.tbxMaxCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpWorkshopDate = new System.Windows.Forms.DateTimePicker();
            this.tbxWorkshopDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxWorkshopName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAvailableWorkshops = new System.Windows.Forms.ListBox();
            this.tpPeople = new System.Windows.Forms.TabPage();
            this.btnUpdateWorkshop = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpWorkshop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpWorkshop);
            this.tabControl1.Controls.Add(this.tpPeople);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpWorkshop
            // 
            this.tpWorkshop.Controls.Add(this.btnUpdateWorkshop);
            this.tpWorkshop.Controls.Add(this.btnCreateWorkshop);
            this.tpWorkshop.Controls.Add(this.label6);
            this.tpWorkshop.Controls.Add(this.tbxWorkshopRoomNmr);
            this.tpWorkshop.Controls.Add(this.tbxWorkshopAdress);
            this.tpWorkshop.Controls.Add(this.tbxWorkshopURL);
            this.tpWorkshop.Controls.Add(this.label5);
            this.tpWorkshop.Controls.Add(this.rbWorkshopOnline);
            this.tpWorkshop.Controls.Add(this.rbWorkshopInBuilding);
            this.tpWorkshop.Controls.Add(this.tbxMaxCapacity);
            this.tpWorkshop.Controls.Add(this.label4);
            this.tpWorkshop.Controls.Add(this.label3);
            this.tpWorkshop.Controls.Add(this.dtpWorkshopDate);
            this.tpWorkshop.Controls.Add(this.tbxWorkshopDescription);
            this.tpWorkshop.Controls.Add(this.label2);
            this.tpWorkshop.Controls.Add(this.tbxWorkshopName);
            this.tpWorkshop.Controls.Add(this.label1);
            this.tpWorkshop.Controls.Add(this.lbxAvailableWorkshops);
            this.tpWorkshop.Location = new System.Drawing.Point(4, 22);
            this.tpWorkshop.Name = "tpWorkshop";
            this.tpWorkshop.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorkshop.Size = new System.Drawing.Size(768, 400);
            this.tpWorkshop.TabIndex = 0;
            this.tpWorkshop.Text = "Workshops";
            this.tpWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnCreateWorkshop
            // 
            this.btnCreateWorkshop.Location = new System.Drawing.Point(9, 232);
            this.btnCreateWorkshop.Name = "btnCreateWorkshop";
            this.btnCreateWorkshop.Size = new System.Drawing.Size(301, 47);
            this.btnCreateWorkshop.TabIndex = 16;
            this.btnCreateWorkshop.Text = "Create new Workshop";
            this.btnCreateWorkshop.UseVisualStyleBackColor = true;
            this.btnCreateWorkshop.Click += new System.EventHandler(this.btnCreateWorkshop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adress + Room";
            // 
            // tbxWorkshopRoomNmr
            // 
            this.tbxWorkshopRoomNmr.Location = new System.Drawing.Point(268, 206);
            this.tbxWorkshopRoomNmr.Name = "tbxWorkshopRoomNmr";
            this.tbxWorkshopRoomNmr.Size = new System.Drawing.Size(42, 20);
            this.tbxWorkshopRoomNmr.TabIndex = 14;
            // 
            // tbxWorkshopAdress
            // 
            this.tbxWorkshopAdress.Location = new System.Drawing.Point(91, 206);
            this.tbxWorkshopAdress.Name = "tbxWorkshopAdress";
            this.tbxWorkshopAdress.Size = new System.Drawing.Size(171, 20);
            this.tbxWorkshopAdress.TabIndex = 13;
            // 
            // tbxWorkshopURL
            // 
            this.tbxWorkshopURL.Location = new System.Drawing.Point(47, 206);
            this.tbxWorkshopURL.Name = "tbxWorkshopURL";
            this.tbxWorkshopURL.Size = new System.Drawing.Size(263, 20);
            this.tbxWorkshopURL.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "URL:";
            // 
            // rbWorkshopOnline
            // 
            this.rbWorkshopOnline.AutoSize = true;
            this.rbWorkshopOnline.Location = new System.Drawing.Point(203, 174);
            this.rbWorkshopOnline.Name = "rbWorkshopOnline";
            this.rbWorkshopOnline.Size = new System.Drawing.Size(107, 17);
            this.rbWorkshopOnline.TabIndex = 10;
            this.rbWorkshopOnline.TabStop = true;
            this.rbWorkshopOnline.Text = "Online Workshop";
            this.rbWorkshopOnline.UseVisualStyleBackColor = true;
            // 
            // rbWorkshopInBuilding
            // 
            this.rbWorkshopInBuilding.AutoSize = true;
            this.rbWorkshopInBuilding.Location = new System.Drawing.Point(12, 174);
            this.rbWorkshopInBuilding.Name = "rbWorkshopInBuilding";
            this.rbWorkshopInBuilding.Size = new System.Drawing.Size(107, 17);
            this.rbWorkshopInBuilding.TabIndex = 9;
            this.rbWorkshopInBuilding.TabStop = true;
            this.rbWorkshopInBuilding.Text = "On site workshop";
            this.rbWorkshopInBuilding.UseVisualStyleBackColor = true;
            this.rbWorkshopInBuilding.CheckedChanged += new System.EventHandler(this.rbWorkshopInBuilding_CheckedChanged);
            // 
            // tbxMaxCapacity
            // 
            this.tbxMaxCapacity.Location = new System.Drawing.Point(110, 147);
            this.tbxMaxCapacity.Name = "tbxMaxCapacity";
            this.tbxMaxCapacity.Size = new System.Drawing.Size(200, 20);
            this.tbxMaxCapacity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of workshop:";
            // 
            // dtpWorkshopDate
            // 
            this.dtpWorkshopDate.Location = new System.Drawing.Point(110, 114);
            this.dtpWorkshopDate.Name = "dtpWorkshopDate";
            this.dtpWorkshopDate.Size = new System.Drawing.Size(200, 20);
            this.dtpWorkshopDate.TabIndex = 5;
            // 
            // tbxWorkshopDescription
            // 
            this.tbxWorkshopDescription.Location = new System.Drawing.Point(110, 34);
            this.tbxWorkshopDescription.Multiline = true;
            this.tbxWorkshopDescription.Name = "tbxWorkshopDescription";
            this.tbxWorkshopDescription.Size = new System.Drawing.Size(200, 63);
            this.tbxWorkshopDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // tbxWorkshopName
            // 
            this.tbxWorkshopName.Location = new System.Drawing.Point(110, 7);
            this.tbxWorkshopName.Name = "tbxWorkshopName";
            this.tbxWorkshopName.Size = new System.Drawing.Size(200, 20);
            this.tbxWorkshopName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of workshop:";
            // 
            // lbxAvailableWorkshops
            // 
            this.lbxAvailableWorkshops.FormattingEnabled = true;
            this.lbxAvailableWorkshops.Location = new System.Drawing.Point(316, 7);
            this.lbxAvailableWorkshops.Name = "lbxAvailableWorkshops";
            this.lbxAvailableWorkshops.Size = new System.Drawing.Size(446, 381);
            this.lbxAvailableWorkshops.TabIndex = 0;
            // 
            // tpPeople
            // 
            this.tpPeople.Location = new System.Drawing.Point(4, 22);
            this.tpPeople.Name = "tpPeople";
            this.tpPeople.Padding = new System.Windows.Forms.Padding(3);
            this.tpPeople.Size = new System.Drawing.Size(768, 400);
            this.tpPeople.TabIndex = 1;
            this.tpPeople.Text = "People";
            this.tpPeople.UseVisualStyleBackColor = true;
            // 
            // btnUpdateWorkshop
            // 
            this.btnUpdateWorkshop.Location = new System.Drawing.Point(9, 286);
            this.btnUpdateWorkshop.Name = "btnUpdateWorkshop";
            this.btnUpdateWorkshop.Size = new System.Drawing.Size(301, 46);
            this.btnUpdateWorkshop.TabIndex = 17;
            this.btnUpdateWorkshop.Text = "Update selected workshop";
            this.btnUpdateWorkshop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpWorkshop.ResumeLayout(false);
            this.tpWorkshop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpWorkshop;
        private System.Windows.Forms.TabPage tpPeople;
        private System.Windows.Forms.Button btnCreateWorkshop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxWorkshopRoomNmr;
        private System.Windows.Forms.TextBox tbxWorkshopAdress;
        private System.Windows.Forms.TextBox tbxWorkshopURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbWorkshopOnline;
        private System.Windows.Forms.RadioButton rbWorkshopInBuilding;
        private System.Windows.Forms.TextBox tbxMaxCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpWorkshopDate;
        private System.Windows.Forms.TextBox tbxWorkshopDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxWorkshopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAvailableWorkshops;
        private System.Windows.Forms.Button btnUpdateWorkshop;
    }
}

