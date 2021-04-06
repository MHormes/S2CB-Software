
namespace MessageBoardAssignment
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
            this.tbxTeacherName = new System.Windows.Forms.TextBox();
            this.tbxTeachedClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher name:";
            // 
            // tbxTeacherName
            // 
            this.tbxTeacherName.Location = new System.Drawing.Point(97, 6);
            this.tbxTeacherName.Name = "tbxTeacherName";
            this.tbxTeacherName.Size = new System.Drawing.Size(100, 20);
            this.tbxTeacherName.TabIndex = 1;
            // 
            // tbxTeachedClass
            // 
            this.tbxTeachedClass.Location = new System.Drawing.Point(97, 31);
            this.tbxTeachedClass.Name = "tbxTeachedClass";
            this.tbxTeachedClass.Size = new System.Drawing.Size(100, 20);
            this.tbxTeachedClass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class Teached";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(14, 74);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(183, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 131);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbxTeachedClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTeacherName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTeacherName;
        private System.Windows.Forms.TextBox tbxTeachedClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogIn;
    }
}

