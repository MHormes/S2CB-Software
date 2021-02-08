using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class Boat: Transportation
    {
        private string company;
        private int weight;

        public Boat(string company, int weight, int speed): base(speed)
        {
            this.company = company;
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"Boat: Company: {company}, Weight: {weight} tons, Speed: {base.ToString()}";
        }
    }
}
