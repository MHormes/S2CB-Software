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

        public string Name { get ; set; }
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

        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Description}. URL: {this.URL}. Capacity: {this.attendees.Count()}/{this.MaxCapacity}. Will be held at: {this.Date}";
        }
    }
}
