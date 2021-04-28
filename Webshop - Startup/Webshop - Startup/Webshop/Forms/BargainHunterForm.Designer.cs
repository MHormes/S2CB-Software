namespace Webshop
{
    partial class BargainHunterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lbBargains = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPriceLimit = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(121, 197);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(78, 25);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lbBargains
            // 
            this.lbBargains.FormattingEnabled = true;
            this.lbBargains.Location = new System.Drawing.Point(6, 36);
            this.lbBargains.Margin = new System.Windows.Forms.Padding(2);
            this.lbBargains.Name = "lbBargains";
            this.lbBargains.Size = new System.Drawing.Size(495, 160);
            this.lbBargains.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desired price limit:";
            // 
            // tbPriceLimit
            // 
            this.tbPriceLimit.Location = new System.Drawing.Point(104, 11);
            this.tbPriceLimit.Margin = new System.Windows.Forms.Padding(2);
            this.tbPriceLimit.Name = "tbPriceLimit";
            this.tbPriceLimit.Size = new System.Drawing.Size(52, 20);
            this.tbPriceLimit.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 6);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 25);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update for new bargains";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(58, 202);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(52, 20);
            this.tbQuantity.TabIndex = 11;
            // 
            // BargainHunterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 231);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPriceLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lbBargains);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BargainHunterForm";
            this.Text = "BargainHunterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ListBox lbBargains;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPriceLimit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}