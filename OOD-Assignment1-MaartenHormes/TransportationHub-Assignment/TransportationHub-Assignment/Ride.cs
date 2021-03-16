using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHub_Assignment
{
    [Serializable]
    public class Ride : IComparable<Ride>
    {
        private bool completed;
        private int amountOfPersons;
        private double volumeOfCargo;
        private double weightOfCargo;
        private DateTime startTime;
        private DateTime? endTime;

        public bool Completed { get; set; }

        public Vehicle Vehicle
        { get; set; }

        public double PriceOfRide
        {
            get; set;
        }

        private double StartingPrice
        {
            get; set;
        }
        public int Kilometers { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime
        {
            get; set;
        }
        public Ride(Vehicle vehicle, bool completed, int amountOfPersons, double volumeOfCargo, double weightOfCargo, double priceOfRide, double startingPrice, int kilometers, DateTime startTime, DateTime? endTime)
        {
            Vehicle = vehicle;
            this.completed = completed;
            this.amountOfPersons = amountOfPersons;
            this.volumeOfCargo = volumeOfCargo;
            this.weightOfCargo = weightOfCargo;
            PriceOfRide = priceOfRide;
            StartingPrice = startingPrice;
            Kilometers = kilometers;
            this.startTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"Completed:{completed}. Start date and time: {startTime}. End date and time:{endTime}. Type:{Vehicle.Type}({Vehicle.LicensePlate}) Starting/Total price{StartingPrice}/{PriceOfRide}";
        }

        public int CompareTo(Ride other)
        {
            if(other.StartTime > StartTime){
                return -1;}
            else if(other.startTime < StartTime) { return 1; }
            else
            {
                if(other.Kilometers > Kilometers) { return -1; }
                else
                {
                    return 1;
                }
            }
        }
    }
}
