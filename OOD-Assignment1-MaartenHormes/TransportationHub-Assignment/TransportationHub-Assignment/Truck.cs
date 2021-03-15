using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TransportationHub_Assignment
{
    [Serializable]
    public class Truck: Vehicle
    {
        private bool available;
        private double maxWeight;
        private double maxVolume;

        public bool Available
        {
            get { return this.available; }
            set { this.available = value; }
        }

        public double MaxWeight
        {
            get { return this.maxWeight; }
            set { this.maxWeight = value; }
        }

        public double MaxVolume
        {
            get { return this.maxVolume; }
            set { this.maxVolume = value; }
        }

        public Truck(bool available, double maxWeight, double maxVolume, string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM): base(makeAndModel, licensePlate, gasPerKM, pricePerKM, consumedFuel, totalKM)
        {
            Available = available;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }
    }
}
