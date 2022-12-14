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
    public class Van:Vehicle
    {
        
        private int maxPassenger;
        private double maxWeight;
        private double maxVolume;

        

        public int MaxPassenger
        {
            get { return this.maxPassenger; }
            set { this.maxPassenger = value; }
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

        public Van(string type, int maxPassenger, double maxWeight, double maxVolume, string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM): base(type, makeAndModel, licensePlate, gasPerKM, pricePerKM, consumedFuel, totalKM)
        {
            Type = type;
            MaxPassenger = maxPassenger;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }

        public override string ToString()
        {
            return $"Type:{Type}.Max people/load/volume:{MaxPassenger}/{MaxWeight}/{MaxVolume}.Name:{MakeAndModel}.License plate:{LicensePlate}";
        }
        
    }
}
