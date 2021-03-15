using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Manager
    { 
        List<Astronaut> AstronautList = new List<Astronaut>();
        List<Mission> MissionList = new List<Mission>();

        public bool AddAstronaut(Astronaut a)
        {
            foreach (Astronaut Oa in AstronautList)
            {
                if(Oa.Name == a.Name)
                {
                    return false;
                }
            }
            this.AstronautList.Add(a);
            return true;

        }

        public bool AddMission(Mission m)
        {
            foreach(Mission Om in MissionList)
            {
                if(Om.Name == m.Name)
                {
                    return false;
                }
            }
            this.MissionList.Add(m);
            return true;
        }

        public List<Astronaut> GetAstronauts()
        {
            return AstronautList;
        }

        public List<Mission> GetMissions()
        {
            return MissionList;
        }

        public Astronaut GetAstronaut(string name)
        {
            foreach (Astronaut a in AstronautList)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }
            return null;
        }

        public Mission GetMission(string name)
        {
            foreach (Mission m in MissionList)
            {
                if (m.Name == name)
                {
                    return m;
                }
            }
            return null;
        }

    }
}
