using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class WorkshopOnline : IWorkshop
    {
        List<Teacher> teachers;
        List<IPerson> attendees;

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int MaxCapacity { get; set; }
        public string URL { get; set; }
        public bool Started { get; set; }

        public WorkshopOnline(string name, string description, int maxCapacity, DateTime date, string url)
        {
            this.Name = name;
            this.Description = description;
            this.Date = date;
            this.URL = url;
            this.MaxCapacity = maxCapacity;

            teachers = new List<Teacher>();
            attendees = new List<IPerson>();
            this.Started = false;
        }

        public void AssignPassword(int pcn)
        {
            foreach (IPerson person in attendees)
            {
                if (person.PCN == pcn)
                {
                    person.Password.Add(new Tuple<string, string>(Name, CreatePassword()));
                }
            }
        }

        public string CreatePassword()
        {
            Random rnd = new Random();
            int n = 0;
            int length = 5;
            string password = "";

            for (int p = 0; p < length; p++)
            {
                int decideChar = rnd.Next(3);

                if (decideChar == 0)
                {
                    n = rnd.Next(65, 91); // Generate capital letter
                }
                else if (decideChar == 1)
                {
                    n = rnd.Next(97, 123); // Generate lowercase letter
                }
                else
                {
                    n = rnd.Next(48, 58); // Generate a number
                }
                // Convert integer to character
                password += (char)n;
            }

            return password;
        }

        public List<Teacher> GetTeachers()
        {
            return this.teachers;
        }

        public List<IPerson> GetStudents()
        {
            return this.attendees;
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void RemovePerson(IPerson person)
        {
            attendees.Remove(person);
        }

        public void AssignTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void EnrolStudent(IPerson person)
        {
            attendees.Add(person);
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Description}. URL: {this.URL}. Capacity: {this.attendees.Count()}/{this.MaxCapacity}. Will be held at: {this.Date}";
        }


    }
}
