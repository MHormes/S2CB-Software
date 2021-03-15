using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHub_Assignment
{
    [Serializable]
    public class Car: Vehicle
    {
        private bool available;
        private int maxPassenger;

        public bool Available
        {
            get { return this.available; }
            set { this.available = value; }
        }

        public int MaxPassenger
        {
            get { return this.maxPassenger; }
            set { this.maxPassenger = value; }
        }
        public Car(bool available, int maxPassenger, string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM): base(makeAndModel, licensePlate, gasPerKM, pricePerKM, consumedFuel, totalKM)
        {
            Available = available;
            MaxPassenger = maxPassenger;
        }
    }
}
