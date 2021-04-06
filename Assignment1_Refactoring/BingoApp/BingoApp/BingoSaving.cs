using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BingoApp
{
    public class BingoSaving
    {
        public (List<int>, List<int>) LoadBingoGame()
        {
            // Load game
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MyBingoGame files (*.mbg)|*.mbg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                
                // Load available numbers
                List<int> availableNumbers = new List<int>();
                // Load already drawn numbers
                List<int> drawnNumbers = new List<int>();

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    // Read first line with available numbers
                    string s = sr.ReadLine().Trim();
                    string[] numbers = s.Split(' ');
                    foreach (string n in numbers)
                    {
                        availableNumbers.Add(Convert.ToInt32(n.Trim()));
                    }
                    // Read second line with drawn numbers
                    s = sr.ReadLine().Trim();
                    numbers = s.Split(' ');
                    foreach (string n in numbers)
                    {
                        drawnNumbers.Add(Convert.ToInt32(n.Trim()));
                    }

                    return (availableNumbers, drawnNumbers);
                }
                catch (IOException)
                { MessageBox.Show("Error reading file"); }
                catch (Exception ex)
                { MessageBox.Show($"Something went wrong when loading the file: {ex.ToString()}"); }
                finally
                {
                    if (sr != null)
                    { sr.Close(); }
                }
            }
            return (null, null);
        }

        public void SaveBingoGame(List<int> availableNumbers, int lastNumber, List<int> drawnNumbers)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "MyBingoGame";
            sfd.DefaultExt = "mbg";
            sfd.Filter = "MyBingoGame files (*.mbg)|*.mbg|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                string fileName = sfd.FileName;
                try
                {
                    fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    // Save available numbers
                    foreach (int n in availableNumbers)
                    { sw.Write(n + " "); }
                    // Write new line
                    sw.Write(Environment.NewLine);
                    // Save already drawn numbers
                    sw.Write(lastNumber + " ");
                    foreach (int n in drawnNumbers)
                    { sw.Write(n + " "); }
                }
                catch (IOException)
                { MessageBox.Show("Error writing file"); }
                finally
                {
                    if (sw != null)
                    { sw.Close(); }
                }
            }
        }
    }
    
}
