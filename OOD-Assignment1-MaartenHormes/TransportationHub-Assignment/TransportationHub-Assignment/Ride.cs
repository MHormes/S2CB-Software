using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHub_Assignment
{
    [Serializable]
    public class Ride
    {
        private Vehicle vehicle;
        private bool completed;
        private int amountOfPersons;
        private double volumeOfCargo;
        private double weightOfCargo;
        private decimal priceOfRide;
        private decimal startingPrice;
        private int kilometers;
        private DateTime startTime;
        private DateTime endTime;

        public bool Completed { get; set; }

        public Ride(Vehicle vehicle, bool completed, int amountOfPersons, double volumeOfCargo, double weightOfCargo, decimal priceOfRide, decimal startingPrice, int kilometers, DateTime startTime, DateTime endTime)
        {
            this.vehicle = vehicle;
            this.completed = completed;
            this.amountOfPersons = amountOfPersons;
            this.volumeOfCargo = volumeOfCargo;
            this.weightOfCargo = weightOfCargo;
            this.priceOfRide = priceOfRide;
            this.startingPrice = startingPrice;
            this.kilometers = kilometers;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public override string ToString()
        {
            return $"Completed:{completed}. Start date and time: {startTime}. End date and time:{endTime}. Type:{vehicle.Type}({vehicle.LicensePlate}) Starting/Total price{startingPrice}/{priceOfRide}";
        }
    }
}
