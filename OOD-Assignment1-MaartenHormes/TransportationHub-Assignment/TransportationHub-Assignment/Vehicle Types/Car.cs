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
        private int maxPassenger;

        public int MaxPassenger
        {
            get { return this.maxPassenger; }
            set { this.maxPassenger = value; }
        }
        public Car(string type, int maxPassenger, string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM): base(type, makeAndModel, licensePlate, gasPerKM, pricePerKM, consumedFuel, totalKM)
        {
            Type = type;
            MaxPassenger = maxPassenger;
        }

        public override string ToString()
        {
            return $"Type:{Type}.Max people:{MaxPassenger}.Name:{MakeAndModel}.License plate:{LicensePlate}";
        }
    }
}
