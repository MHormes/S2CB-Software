using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class WorkshopInBuilding : IWorkshop
    {
        List<Teacher> teachers;
        List<IPerson> attendees;

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Adress { get; set; }
        public double RoomNmr { get; set; }
        public int MaxCapacity { get; set; }
        public bool Started { get; set; }

        public WorkshopInBuilding(string name, string description, DateTime date, int maxCapacity, string adress, double roomNmr)
        {
            this.Name = name;
            this.Description = description;
            this.Date = date;
            this.MaxCapacity = maxCapacity;
            this.Adress = adress;
            this.RoomNmr = roomNmr;
            teachers = new List<Teacher>();
            attendees = new List<IPerson>();
            this.Started = false;
        }

        public void AssignSeat(int pcn)
        {

        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Description}. Adress + Room: {this.Adress} {this.RoomNmr}. Capacity: {this.attendees.Count()}/{this.MaxCapacity}. Will be held: {this.Date}";
        }
    }
}
