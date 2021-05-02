using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class WorkshopManager
    {

        List<IWorkshop> workshops;
        public WorkshopManager()
        {
            workshops = new List<IWorkshop>();
        }

        public Exception CreateNewWorkshop(bool inBuilding, string name, string description, string maxCapacity, DateTime date, string url, string adress, string roomNmr)
        {
            try
            {
                if(!Regex.IsMatch(maxCapacity, @"^[0-9]*$"))
                {
                    //throw exception
                }
                if(Regex.IsMatch(roomNmr, @"^[0-9]*\.?[0-9]*$"))
                {
                    //throw new exception
                }

                if(inBuilding == true)
                {
                    IWorkshop newWorkshop = new WorkshopInBuilding(name, description, date, Convert.ToInt32(maxCapacity), adress, Convert.ToDouble(roomNmr));
                    workshops.Add(newWorkshop);
                }
                else
                {
                    IWorkshop newWorkshop = new WorkshopOnline(name, description, Convert.ToInt32(maxCapacity), date, url);
                    workshops.Add(newWorkshop);
                }
                return null;
            }
            catch(Exception ex)
            {
                return ex;
            }
        }

        public IWorkshop GetWorkshop(string name)
        {
            return null;
        }

        public List<IWorkshop> GetWorkshops()
        {
            return this.workshops;
        }

        public void StartWorkshop(string name)
        {

        }

        public Exception AssignTeacher(IWorkshop workshop, IPerson person)
        {
            return null;
        }

        public bool EnrolPerson(IWorkshop workshop, IPerson attendee)
        {
            return true;
        }

        public void SaveWorkshop()
        {

        }
    }
}
