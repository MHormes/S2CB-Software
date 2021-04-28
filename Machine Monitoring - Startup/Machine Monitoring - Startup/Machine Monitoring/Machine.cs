using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Machine_Monitoring
{
    public class Machine
    {
        public string Name
        {
            get; set;
        }

        public int Temperature
        {
            get; set;
        }

        public int Pressure
        {
            get; set;
        }
        public Machine(string name, int temp, int pressure)
        {
            Name = name;
            Temperature = temp;
            Pressure = pressure;
        }

        public string WarningTemp()
        {
            if(Temperature > 120)
            {
                return $"{Name} is too hot";
            }
            else if(Temperature < 80)
            {
                return $"{Name} is too cold";
            }
            else
            {
                return null;
            }
             
        }

        public string WarningPress()
        {
            if (Pressure > 80)
            {
                return $"{Name} is blowing up!";
            }
            else if (Pressure < 60)
            {
                return $"{Name} is deflating ;)";
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"name: {Name}; current temp: {Temperature}; current press: {Pressure}";
        }
    }
}
