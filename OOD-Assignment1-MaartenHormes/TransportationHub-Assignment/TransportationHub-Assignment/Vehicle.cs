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
    public class Vehicle : IComparable<Vehicle>
    {
        protected bool available;
        protected string makeAndModel;
        protected string licensePlate;
        protected double gasPerKM;
        protected double pricePerKM;
        protected decimal consumedFuel;
        protected double totalKM;


        public bool Available
        { get { return this.available; } set { this.available = value; } }
        public string MakeAndModel
        { get { return this.makeAndModel; } set { this.makeAndModel = value; } }

        public string LicensePlate
        { get { return this.licensePlate; } set { this.licensePlate = value; } }

        public double GasPerKM
        { get { return this.gasPerKM; } set { this.gasPerKM = value; } }

        public double PricePerKM
        { get { return this.pricePerKM; } set { this.pricePerKM = value; } }

        public decimal ConsumedFuel
        { get { return this.consumedFuel; } set { this.consumedFuel = value; } }

        public double TotalKM
        { get { return this.totalKM; } set { this.totalKM = value; } }

        public Vehicle(string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM)
        {
            Available = true;
            MakeAndModel = makeAndModel;
            LicensePlate = licensePlate;
            GasPerKM = gasPerKM;
            PricePerKM = pricePerKM;
            ConsumedFuel = consumedFuel;
            TotalKM = totalKM;
        }

        public override string ToString()
        {
            return $"{makeAndModel}:{licensePlate}";
        }

        public int CompareTo(Vehicle other)
        {
            int firstThis = Convert.ToInt32(LicensePlate.Substring(0, 3));
            int firstOther = Convert.ToInt32(other.LicensePlate.Substring(0, 3));
            string secondThis = LicensePlate.Substring(3, 2);
            string secondOther = other.LicensePlate.Substring(3, 2);
            if(firstOther > firstThis) { return -1; }
            else if(firstOther < firstThis){ return 1; }
            else
            {
                return string.Compare(secondThis, secondOther);
            }
        }
    }
}
