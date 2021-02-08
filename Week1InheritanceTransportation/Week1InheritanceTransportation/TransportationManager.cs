using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class TransportationManager
    {
        List<Bicycle> bicycles;
        List<Boat> boats;
        List<Car> cars;

        public TransportationManager()
        {
            bicycles = new List<Bicycle>();
            boats = new List<Boat>();
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void AddBoat(Boat boat)
        {
            boats.Add(boat);
        }
        public void Bicycle(Bicycle bicycle)
        {
            bicycles.Add(bicycle);
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }
        public List<Boat> GetBoats()
        {
            return this.boats;
        }
        public List<Bicycle> GetBicycles()
        {
            return this.bicycles;
        }

    }
}
