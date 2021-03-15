
namespace DataCollectingApp
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
            this.pnlGold = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.btnSetCityName = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxFavoriteClubs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGold.SuspendLayout();
            this.pnlRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGold
            // 
            this.pnlGold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlGold.Controls.Add(this.btnSetCityName);
            this.pnlGold.Controls.Add(this.tbxCity);
            this.pnlGold.Controls.Add(this.label1);
            this.pnlGold.Location = new System.Drawing.Point(12, 12);
            this.pnlGold.Name = "pnlGold";
            this.pnlGold.Size = new System.Drawing.Size(825, 100);
            this.pnlGold.TabIndex = 0;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.Controls.Add(this.btnConfirm);
            this.pnlRed.Controls.Add(this.label2);
            this.pnlRed.Controls.Add(this.tbxFavoriteClubs);
            this.pnlRed.Location = new System.Drawing.Point(12, 118);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(825, 100);
            this.pnlRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of city";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(278, 28);
            this.tbxCity.Multiline = true;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(169, 50);
            this.tbxCity.TabIndex = 1;
            // 
            // btnSetCityName
            // 
            this.btnSetCityName.Location = new System.Drawing.Point(490, 28);
            this.btnSetCityName.Name = "btnSetCityName";
            this.btnSetCityName.Size = new System.Drawing.Size(177, 50);
            this.btnSetCityName.TabIndex = 2;
            this.btnSetCityName.Text = "set city name";
            this.btnSetCityName.UseVisualStyleBackColor = true;
            this.btnSetCityName.Click += new System.EventHandler(this.btnSetCityName_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(618, 40);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(204, 45);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxFavoriteClubs
            // 
            this.tbxFavoriteClubs.Location = new System.Drawing.Point(18, 40);
            this.tbxFavoriteClubs.Multiline = true;
            this.tbxFavoriteClubs.Name = "tbxFavoriteClubs";
            this.tbxFavoriteClubs.Size = new System.Drawing.Size(561, 45);
            this.tbxFavoriteClubs.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "What are your favorite footballclubs?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 241);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.pnlGold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlGold.ResumeLayout(false);
            this.pnlGold.PerformLayout();
            this.pnlRed.ResumeLayout(false);
            this.pnlRed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGold;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Button btnSetCityName;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFavoriteClubs;
    }
}

