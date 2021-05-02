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
                //Check uers input and unique name
                ValidateUserInput(roomNmr, maxCapacity, date);
                if (GetWorkshop(name) != null)
                {
                    //throw new exception?
                }

                if (inBuilding == true)
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

        public Exception UpdateWorkshop(string oldName, string newName, string description, string maxCapacity, DateTime date, string url, string adress, string roomNmr)
        {
            try
            {
                IWorkshop workshop = GetWorkshop(oldName);

                //Check user input
                ValidateUserInput(roomNmr, maxCapacity, date);
                if(oldName != newName)
                {
                    if(GetWorkshop(newName) != null)
                    {
                        //throw new exception?
                    }
                }

                workshop.Name = newName;
                workshop.Description = description;
                workshop.MaxCapacity = Convert.ToInt32(maxCapacity);
                workshop.Date = date;

                if(workshop is WorkshopInBuilding)
                {
                    ((WorkshopInBuilding)workshop).Adress = adress;
                    ((WorkshopInBuilding)workshop).RoomNmr = Convert.ToDouble(roomNmr);
                }
                else
                {
                    ((WorkshopOnline)workshop).URL = url;
                }
                return null;
            }
            catch(Exception ex)
            {
                return ex;
            }
        }

        public bool DeleteWorkshop(string name)
        {
            return true;
        }

        public IWorkshop GetWorkshop(string name)
        {
            foreach(IWorkshop workshop in workshops)
            {
                if(workshop.Name == name)
                {
                    return workshop;
                }
            }
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

        //Validate the user input and throw needed exceptions
        public bool ValidateUserInput(string roomNmr, string maxCapacity, DateTime date)
        {
            if (!Regex.IsMatch(maxCapacity, @"^[0-9]*$"))
            {
                //throw exception
            }
            if (Regex.IsMatch(roomNmr, @"^[0-9]*\.?[0-9]*$"))
            {
                //throw new exception
            }
            
            if (date < DateTime.Now)
            {
                //throw new exception?
            }
            return true;
        }
    }
}
