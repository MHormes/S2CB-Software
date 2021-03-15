using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Astronaut : IComparable<Astronaut>
    {
        Gender gender;
        private string nationality;

        List<Mission> MissionDoneByAstronaut;

        public string Name { get; set; }

        public Astronaut(string name, Gender gender, string nationality)
        {
            Name = name;
            this.gender = gender;
            this.nationality = nationality;
            MissionDoneByAstronaut = new List<Mission>();
        }

        public bool AddMissionToAstronaut(Mission m)
        {
            foreach (Mission Om in MissionDoneByAstronaut)
            {
                if (Om == m)
                {
                    return false;
                }
            }
            this.MissionDoneByAstronaut.Add(m);
            return true;
        }

        public List<Mission> GetMissionsForAstronaut()
        {
            return MissionDoneByAstronaut;
        }
        public override string ToString()
        {
            return $"{Name}: Gender:{gender}, nationality:{nationality}";
        }

        public int CompareTo(Astronaut other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }
}
