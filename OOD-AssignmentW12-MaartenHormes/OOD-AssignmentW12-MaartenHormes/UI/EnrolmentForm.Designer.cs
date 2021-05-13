
namespace OOD_AssignmentW12_MaartenHormes
{
    partial class EnrolmentForm
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
            this.Assigned = new System.Windows.Forms.Label();
            this.lbxAssigned = new System.Windows.Forms.ListBox();
            this.lbxAvailable = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnrolmentInfo = new System.Windows.Forms.Label();
            this.btnEnrolmentAssign = new System.Windows.Forms.Button();
            this.btnEnrolmentRemove = new System.Windows.Forms.Button();
            this.btnBackToWorkshopInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Assigned
            // 
            this.Assigned.AutoSize = true;
            this.Assigned.Location = new System.Drawing.Point(12, 41);
            this.Assigned.Name = "Assigned";
            this.Assigned.Size = new System.Drawing.Size(50, 13);
            this.Assigned.TabIndex = 0;
            this.Assigned.Text = "Assigned";
            // 
            // lbxAssigned
            // 
            this.lbxAssigned.FormattingEnabled = true;
            this.lbxAssigned.Location = new System.Drawing.Point(12, 57);
            this.lbxAssigned.Name = "lbxAssigned";
            this.lbxAssigned.Size = new System.Drawing.Size(385, 186);
            this.lbxAssigned.TabIndex = 1;
            // 
            // lbxAvailable
            // 
            this.lbxAvailable.FormattingEnabled = true;
            this.lbxAvailable.Location = new System.Drawing.Point(403, 57);
            this.lbxAvailable.Name = "lbxAvailable";
            this.lbxAvailable.Size = new System.Drawing.Size(384, 186);
            this.lbxAvailable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available";
            // 
            // lblEnrolmentInfo
            // 
            this.lblEnrolmentInfo.AutoSize = true;
            this.lblEnrolmentInfo.Location = new System.Drawing.Point(12, 13);
            this.lblEnrolmentInfo.Name = "lblEnrolmentInfo";
            this.lblEnrolmentInfo.Size = new System.Drawing.Size(35, 13);
            this.lblEnrolmentInfo.TabIndex = 4;
            this.lblEnrolmentInfo.Text = "label2";
            // 
            // btnEnrolmentAssign
            // 
            this.btnEnrolmentAssign.Location = new System.Drawing.Point(403, 262);
            this.btnEnrolmentAssign.Name = "btnEnrolmentAssign";
            this.btnEnrolmentAssign.Size = new System.Drawing.Size(384, 53);
            this.btnEnrolmentAssign.TabIndex = 5;
            this.btnEnrolmentAssign.Text = "Assign selected person";
            this.btnEnrolmentAssign.UseVisualStyleBackColor = true;
            this.btnEnrolmentAssign.Click += new System.EventHandler(this.btnEnrolmentAssign_Click);
            // 
            // btnEnrolmentRemove
            // 
            this.btnEnrolmentRemove.Location = new System.Drawing.Point(12, 262);
            this.btnEnrolmentRemove.Name = "btnEnrolmentRemove";
            this.btnEnrolmentRemove.Size = new System.Drawing.Size(385, 53);
            this.btnEnrolmentRemove.TabIndex = 6;
            this.btnEnrolmentRemove.Text = "Remove selected person";
            this.btnEnrolmentRemove.UseVisualStyleBackColor = true;
            this.btnEnrolmentRemove.Click += new System.EventHandler(this.btnEnrolmentRemove_Click);
            // 
            // btnBackToWorkshopInfo
            // 
            this.btnBackToWorkshopInfo.Location = new System.Drawing.Point(12, 358);
            this.btnBackToWorkshopInfo.Name = "btnBackToWorkshopInfo";
            this.btnBackToWorkshopInfo.Size = new System.Drawing.Size(191, 80);
            this.btnBackToWorkshopInfo.TabIndex = 7;
            this.btnBackToWorkshopInfo.Text = "Back to workshop information";
            this.btnBackToWorkshopInfo.UseVisualStyleBackColor = true;
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToWorkshopInfo);
            this.Controls.Add(this.btnEnrolmentRemove);
            this.Controls.Add(this.btnEnrolmentAssign);
            this.Controls.Add(this.lblEnrolmentInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAvailable);
            this.Controls.Add(this.lbxAssigned);
            this.Controls.Add(this.Assigned);
            this.Name = "EnrolmentForm";
            this.Text = "EnrolmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Assigned;
        private System.Windows.Forms.ListBox lbxAssigned;
        private System.Windows.Forms.ListBox lbxAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnrolmentInfo;
        private System.Windows.Forms.Button btnEnrolmentAssign;
        private System.Windows.Forms.Button btnEnrolmentRemove;
        private System.Windows.Forms.Button btnBackToWorkshopInfo;
    }
}