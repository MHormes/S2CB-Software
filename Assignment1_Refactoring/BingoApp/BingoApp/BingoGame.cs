using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public class BingoGame
    {
        private Random rnd;
        private List<int> availableNumbers;

        public BingoGame()
        {
            this.rnd = new Random();
        }

        public void CreateListOfNumbers(string maxNumberS)
        {
            availableNumbers = new List<int>();
            try
            {
                int maxNumber = Convert.ToInt32(maxNumberS);
                for (int i = 1; i < maxNumber + 1; i++)
                { availableNumbers.Add(i); }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int GetRandomNumber()
        {
            int randomIndex = this.rnd.Next(0, availableNumbers.Count);
            int randomNumber = this.availableNumbers[randomIndex];
            this.availableNumbers.RemoveAt(randomIndex);
            return randomNumber;
        }

        public bool NumbersAreRemaining()
        {
            if (availableNumbers.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> GetAvailableNumbersList()
        {
            return this.availableNumbers;
        }
    }
}
