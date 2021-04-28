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

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Started { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public WorkshopOnline(string name, string description, int maxCapacity)
        {
            this.Name = name;
            this.Description = description;
            this.MaxCapacity = maxCapacity;
            this.Started = false;

            teachers = new List<Teacher>();
            attendees = new List<IPerson>();
        }

        public void AssignPassword()
        {

        }
    }
}
