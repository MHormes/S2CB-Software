using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public abstract class Transportation
    {
        protected int id;
        protected int speedKMH;

        public Transportation(int speedKMH)
        {
            this.speedKMH = speedKMH;
        }

        public int ID
        {
            get; set;
        }

        public abstract string MakeSound();
        
        public double CalculateHoursTillDestination(int km)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{speedKMH} km/h";
        }
    }
}
