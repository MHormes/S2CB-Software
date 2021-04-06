namespace BingoApp
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lbxDrawnNumbers = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStopAndSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(60, 39);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(737, 479);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDrawnNumbers
            // 
            this.lbxDrawnNumbers.FormattingEnabled = true;
            this.lbxDrawnNumbers.ItemHeight = 25;
            this.lbxDrawnNumbers.Location = new System.Drawing.Point(821, 39);
            this.lbxDrawnNumbers.Name = "lbxDrawnNumbers";
            this.lbxDrawnNumbers.Size = new System.Drawing.Size(293, 479);
            this.lbxDrawnNumbers.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(610, 543);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(504, 95);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start the bingo";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(56, 816);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(1058, 95);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop the bingo";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStopAndSaveGame
            // 
            this.btnStopAndSaveGame.Enabled = false;
            this.btnStopAndSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAndSaveGame.Location = new System.Drawing.Point(56, 917);
            this.btnStopAndSaveGame.Name = "btnStopAndSaveGame";
            this.btnStopAndSaveGame.Size = new System.Drawing.Size(1058, 95);
            this.btnStopAndSaveGame.TabIndex = 4;
            this.btnStopAndSaveGame.Text = "Stop and save current game";
            this.btnStopAndSaveGame.UseVisualStyleBackColor = true;
            this.btnStopAndSaveGame.Click += new System.EventHandler(this.btnStopAndSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.Location = new System.Drawing.Point(56, 644);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(1058, 95);
            this.btnLoadGame.TabIndex = 5;
            this.btnLoadGame.Text = "Load saved game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "With numbers from 1 -";
            // 
            // tbxMaxNumber
            // 
            this.tbxMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaxNumber.Location = new System.Drawing.Point(467, 564);
            this.tbxMaxNumber.Name = "tbxMaxNumber";
            this.tbxMaxNumber.Size = new System.Drawing.Size(107, 53);
            this.tbxMaxNumber.TabIndex = 7;
            this.tbxMaxNumber.Text = "99";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 1049);
            this.Controls.Add(this.tbxMaxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnStopAndSaveGame);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbxDrawnNumbers);
            this.Controls.Add(this.lblNumber);
            this.Name = "GameForm";
            this.Text = "Play Bingo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ListBox lbxDrawnNumbers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStopAndSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaxNumber;
    }
}

