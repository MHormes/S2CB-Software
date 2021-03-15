using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Mission : IComparable<Mission>
    {
        private DateTime launchDate;
        private DateTime returnDate;
        private string spaceShipType;
        private List<Astronaut> astronautList;

        public string Name { get; set; }

        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceShipType)
        {
            Name = name;
            this.launchDate = launchDate;
            this.returnDate = returnDate;
            this.spaceShipType = spaceShipType;
            astronautList = new List<Astronaut>();
        }

        public bool AddAstronautToMission(Astronaut a)
        {
            foreach (Astronaut Oa in astronautList)
            {
                if (Oa == a)
                {
                    return false;
                }
            }
            this.astronautList.Add(a);
            return true;
        }

        public List<Astronaut> GetAstronautsForThisMission()
        {
            return astronautList;
        }

        public TimeSpan GetFlightDuration()
        {
            return returnDate - launchDate;
        }
        public override string ToString()
        {
            return $"{Name}: Launch: {launchDate.ToShortDateString()}, Return: {returnDate.ToShortDateString()} in ship: {spaceShipType}. With {astronautList.Count()} astronauts";
        }

        public int CompareTo(Mission other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }
}
