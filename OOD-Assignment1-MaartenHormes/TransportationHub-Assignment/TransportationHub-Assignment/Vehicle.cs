using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace TransportationHub_Assignment
{
    [Serializable]
    public abstract class Vehicle : IComparable<Vehicle>
    {
        protected bool available;
        protected string type;
        protected string makeAndModel;
        protected string licensePlate;
        protected double gasPerKM;
        protected double pricePerKM;
        protected decimal consumedFuel;
        protected double totalKM;


        public bool Available
        { get { return this.available; } set { this.available = value; } }

        public string Type { get { return this.type; } set { this.type = value; } }
        public string MakeAndModel
        { get { return this.makeAndModel; } set { this.makeAndModel = value; } }

        public string LicensePlate
        {
            get { return this.licensePlate; }
            set
            {
                //CHECK IF LICENSE PLATE IS IS CORRECT FORMAT
                if (!Regex.IsMatch(value, @"^[0-9]{3}-[A-z]{2}-[0-9]{1}$"))
                {
                    throw new LicensePlateException(value);
                }
                string start = value.Substring(0, 4);
                string middle = value.Substring(4, 2).ToUpper();
                string end = value.Substring(6, 2);

                string correctPlate = start + middle + end;
                this.licensePlate = correctPlate;
            }
        }

        public double GasPerKM
        { get { return this.gasPerKM; } set { this.gasPerKM = value; } }

        public double PricePerKM
        { get { return this.pricePerKM; } set { this.pricePerKM = value; } }

        public decimal ConsumedFuel
        { get { return this.consumedFuel; } set { this.consumedFuel = value; } }

        public double TotalKM
        { get { return this.totalKM; } set { this.totalKM = value; } }

        public Vehicle(string type, string makeAndModel, string licensePlate, double gasPerKM, double pricePerKM, decimal consumedFuel, double totalKM)
        {
            Available = true;
            Type = type;
            MakeAndModel = makeAndModel;
            LicensePlate = licensePlate;
            GasPerKM = gasPerKM;
            PricePerKM = pricePerKM;
            ConsumedFuel = consumedFuel;
            TotalKM = totalKM;
        }

        //compare for sorting on license plate
        public int CompareTo(Vehicle other)
        {
            int firstThis = Convert.ToInt32(LicensePlate.Substring(0, 3));
            int firstOther = Convert.ToInt32(other.LicensePlate.Substring(0, 3));
            string secondThis = LicensePlate.Substring(4, 2);
            string secondOther = other.LicensePlate.Substring(4, 2);
            if (firstOther > firstThis) { return -1; }
            else if (firstOther < firstThis) { return 1; }
            else
            {
                return string.Compare(secondThis, secondOther);
            }
        }
    }
}
