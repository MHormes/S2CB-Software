using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class Bicycle: Transportation
    {
        private bool hasLuggageCarrier;

        public Bicycle(bool hasCarrie, int speed) : base(speed)
        {
            hasLuggageCarrier = hasCarrie;
        }

        public override string MakeSound()
        {
            return "Ring!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
