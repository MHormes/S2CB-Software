using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public partial class GameForm : Form
    {
        private BingoGame bg;
        private BingoSaving bs;
        private Random rnd;

        public GameForm()
        {
            InitializeComponent();
            bg = new BingoGame();
            bs = new BingoSaving();
            rnd = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Initialize game
            lbxDrawnNumbers.Items.Clear();
            btnStart.Enabled = false;
            btnLoadGame.Enabled = false;
            btnStop.Enabled = true;
            btnStopAndSaveGame.Enabled = true;

            //create list of numbers
            bg.CreateListOfNumbers(tbxMaxNumber.Text);
            // Generate first number and show
            lblNumber.Text = bg.GetRandomNumber().ToString();
            // Start timer to generate the remaining numbers
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnLoadGame.Enabled = true;
            btnStop.Enabled = false;
            btnStopAndSaveGame.Enabled = false;
            timer.Stop();

            MessageBox.Show("The bingo has ended!");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Move previous number in to listbox
            int oldNumber = Convert.ToInt32(lblNumber.Text);
            lbxDrawnNumbers.Items.Insert(0, oldNumber);
            // Determine if there are still number to be drawn
            if (bg.NumbersAreRemaining() == true)
            {
                bg.GetRandomNumber();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("The bingo has ended!");
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {

            if (bs.LoadBingoGame() != (null, null))
            {
                // Initialize game
                lbxDrawnNumbers.Items.Clear();
                btnStart.Enabled = false;
                btnLoadGame.Enabled = false;
                btnStop.Enabled = true;
                btnStopAndSaveGame.Enabled = true;

                // Load available numbers
                List<int> availableNumbers = bs.LoadBingoGame().Item1;
                foreach (int n in bs.LoadBingoGame().Item2)
                {
                    lbxDrawnNumbers.Items.Add(n);
                }
            }

            // Generate new number and show
            if (bs.LoadBingoGame().Item1.Count > 0)
            {
                int randomIndex = this.rnd.Next(0, bs.LoadBingoGame().Item1.Count);
                lblNumber.Text = this.bs.LoadBingoGame().Item1[randomIndex].ToString();
                this.bs.LoadBingoGame().Item1.RemoveAt(randomIndex);
                // Start timer to generate the remaining numbers
                timer.Start();
            }
        }

        private void btnStopAndSaveGame_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnLoadGame.Enabled = true;
            btnStop.Enabled = false;
            btnStopAndSaveGame.Enabled = false;
            timer.Stop();
            // Save to file
            List<int> drawnNumbers = new List<int>();
            foreach (int i in lbxDrawnNumbers.Items)
            {
                drawnNumbers.Add(i);
            }
            bs.SaveBingoGame(bg.GetAvailableNumbersList(), Convert.ToInt32(lblNumber.Text), drawnNumbers);

        }
    }
}
