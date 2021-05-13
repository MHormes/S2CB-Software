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
        SaveWorkshops saveWorkshops;
        List<IWorkshop> workshops;
        public WorkshopManager()
        {
            workshops = new List<IWorkshop>();
            saveWorkshops = new SaveWorkshops();
        }

        public Exception CreateNewWorkshop(bool inBuilding, string name, string description, string maxCapacity, DateTime date, string url, string adress, string roomNmr)
        {
            try
            {
                //Check uers input and unique name
                ValidateUserInput(roomNmr, maxCapacity, date);
                if (GetWorkshop(name) != null)
                {
                    throw new NameTakenException(name);
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
            catch (IncorrectNumberInputException numberEx)
            {
                return numberEx;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public Exception UpdateWorkshop(string oldName, string newName, string description, string maxCapacity, DateTime date, string url, string adress, string roomNmr)
        {
            try
            {
                IWorkshop workshop = GetWorkshop(oldName);

                if(workshop.Started == true)
                {
                    throw new WorkshopStartedException();
                }
                //Check user input
                ValidateUserInput(roomNmr, maxCapacity, date);
                if (oldName != newName)
                {
                    if (GetWorkshop(newName) != null)
                    {
                        throw new NameTakenException(newName);
                    }
                }

                workshop.Name = newName;
                workshop.Description = description;
                workshop.MaxCapacity = Convert.ToInt32(maxCapacity);
                workshop.Date = date;

                if (workshop is WorkshopInBuilding)
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
            catch (WorkshopStartedException startedEx)
            {
                return startedEx;
            }
            catch (IncorrectNumberInputException numberEX)
            {
                return numberEX;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public bool DeleteWorkshop(IWorkshop workshop)
        {
            if (workshops.Contains(workshop))
            {
                workshops.Remove(workshop);
                return true;
            }
            return false;
        }

        public IWorkshop GetWorkshop(string name)
        {
            foreach (IWorkshop workshop in workshops)
            {
                if (workshop.Name == name)
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

        public Exception AssignTeacher(IWorkshop workshop, IPerson person)
        {
            try
            {
                if(workshop.Started == true)
                {
                    throw new WorkshopStartedException();
                }
                if (person is Teacher)
                {
                    if (workshop.GetTeachers().Contains((Teacher)person))
                    {
                        throw new TeacherAlreadyAssignedExcpetion();
                    }
                    workshop.AssignTeacher((Teacher)person);
                    return null;
                }
                throw new TeacherNotATeacherException();

            }
            catch (WorkshopStartedException startedEx)
            {
                return startedEx;
            }
            catch (TeacherAlreadyAssignedExcpetion teacherEx)
            {
                return teacherEx;
            }
            catch (TeacherNotATeacherException noTeacherEX)
            {
                return noTeacherEX;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public bool RemoveTeacher(IWorkshop workshop, Teacher person)
        {
            if (workshop.GetTeachers().Contains(person) && !workshop.Started)
            {
                workshop.RemoveTeacher(person);
                return true;
            }
            return false;
        }

        public bool EnrolPerson(IWorkshop workshop, IPerson attendee)
        {
            if(workshop.MaxCapacity > workshop.GetStudents().Count && !workshop.Started)
            {
                workshop.EnrolStudent(attendee);
                if(workshop is WorkshopInBuilding)
                {
                    ((WorkshopInBuilding)workshop).AssignSeat(attendee.PCN);
                }
                else
                {
                    ((WorkshopOnline)workshop).AssignPassword(attendee.PCN);
                }
                return true;
            }
            return false;
        }

        public bool RemovePerson(IWorkshop workshop, IPerson attendee)
        {
            if (workshop.GetStudents().Contains(attendee) && !workshop.Started)
            {
                workshop.RemovePerson(attendee);
                return true;
            }
            return false;
        }
        public void SaveWorkshop()
        {
            saveWorkshops.SaveWorkshopsToFile(workshops);
        }

        //Validate the user input and throw needed exceptions
        private void ValidateUserInput(string roomNmr, string maxCapacity, DateTime date)
        {
            if (!Regex.IsMatch(maxCapacity, @"^[0-9]*$"))
            {
                throw new IncorrectNumberInputException(maxCapacity);
            }
            if (!Regex.IsMatch(roomNmr, @"^[0-9]*\.?[0-9]*$"))
            {
                throw new IncorrectNumberInputException(roomNmr);
            }

            if (date < DateTime.Now)
            {
                throw new DateBeforeNowException(date);
            }
        }
    }
}
