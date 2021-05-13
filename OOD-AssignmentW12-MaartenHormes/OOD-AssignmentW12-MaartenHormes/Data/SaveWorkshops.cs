using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class SaveWorkshops
    {
        public Exception SaveWorkshopsToFile(List<IWorkshop> workshops)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream("WorkshopList", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach (IWorkshop workshop in workshops)
                {
                    if (workshop is WorkshopOnline)
                    {
                        sw.WriteLine($"ONLINE(Title:{workshop.Name}), Teacher:{workshop.GetTeachers().ToString()}, Capacity:{workshop.MaxCapacity}, URL:{((WorkshopOnline)workshop).URL}");
                    }
                    else
                    {
                        sw.WriteLine($"INBUILDING(Title:{workshop.Name}), Teacher:{workshop.GetTeachers().ToString()}, Capacity:{workshop.MaxCapacity}, Location:{((WorkshopInBuilding)workshop).Adress}, {((WorkshopInBuilding)workshop).RoomNmr}");
                    }
                    
                }
                return null;
            }
            catch(Exception ex)
            {
                return ex;
            }
            finally
            {
                if (sw != null) { sw.Close(); }
            }
        }
    }
}
