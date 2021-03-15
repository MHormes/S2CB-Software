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
        private double maxWeight;
        private double maxVolume;

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

        public Truck(string type, double maxWeight, double maxVolume, string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM): base(type, makeAndModel, licensePlate, gasPerKM, pricePerKM, consumedFuel, totalKM)
        {
            Type = type;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }

        public override string ToString()
        {
            return $"Type:{Type}.Max load/volume:{MaxWeight}/{MaxVolume}.Name:{MakeAndModel}.License plate:{LicensePlate}";
        }
    }
}
