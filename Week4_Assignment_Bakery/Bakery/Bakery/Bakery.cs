using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Bakery
{
    public class Bakery
    {

        public List<Sandwich> sandwiches;

        public string Name
        {
            get; set;
        }

        public Bakery(string name)
        {
            Name = name;
            sandwiches = new List<Sandwich>();
        }

        public bool AddSandwich(Sandwich sandwich)
        {
            foreach(Sandwich sw in sandwiches)
            {
                if(sw.Name == sandwich.Name)
                {
                    return false;
                }
            }
            sandwiches.Add(sandwich);
            return true;
        }

        public void CreatePriceList()
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream("priceList.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach(Sandwich sand in sandwiches)
                {
                    sw.WriteLine(sand.NameAndPrice);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("An error occured");   
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void SaveSandwiches()
        {
            FileStream fs = null; 
            BinaryFormatter bf = null;
            
            try
            {
                fs = new FileStream("sandwiches.bin", FileMode.OpenOrCreate, FileAccess.Write); 
                bf = new BinaryFormatter();
                bf.Serialize(fs, sandwiches);
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message); }
            finally 
            { if (fs != null) fs.Close(); }

        }

        public List<Sandwich> LoadSandwiches()
        {
            FileStream fs = null; 
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("sandwiches.bin", FileMode.Open, FileAccess.Read); 
                bf = new BinaryFormatter();
                sandwiches = (List<Sandwich>)bf.Deserialize(fs);
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message); }
            finally 
            { if (fs != null) fs.Close(); }

            return sandwiches;
        }
    }
}
