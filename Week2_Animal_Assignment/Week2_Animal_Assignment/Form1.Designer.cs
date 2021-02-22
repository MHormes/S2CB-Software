
namespace Week2_Animal_Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.btnMakeSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Animal type";
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Duck"});
            this.cbAnimalType.Location = new System.Drawing.Point(80, 35);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(99, 21);
            this.cbAnimalType.TabIndex = 3;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(15, 73);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(164, 23);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(277, 13);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(496, 238);
            this.lbAnimals.TabIndex = 5;
            // 
            // btnMakeSound
            // 
            this.btnMakeSound.Location = new System.Drawing.Point(550, 257);
            this.btnMakeSound.Name = "btnMakeSound";
            this.btnMakeSound.Size = new System.Drawing.Size(223, 23);
            this.btnMakeSound.TabIndex = 6;
            this.btnMakeSound.Text = "Let selected animal make sound";
            this.btnMakeSound.UseVisualStyleBackColor = true;
            this.btnMakeSound.Click += new System.EventHandler(this.btnMakeSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakeSound);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Button btnMakeSound;
    }
}

