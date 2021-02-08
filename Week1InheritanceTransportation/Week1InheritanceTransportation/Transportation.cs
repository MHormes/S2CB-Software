using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class Transportation
    {
        protected int speedKMH;

        public Transportation(int speedKMH)
        {
            this.speedKMH = speedKMH;
        }
        
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
