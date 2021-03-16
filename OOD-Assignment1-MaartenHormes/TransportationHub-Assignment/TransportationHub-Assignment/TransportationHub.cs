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
    public class TransportationHub
    {
        private string name;
        private List<Ride> allRides;
        private List<Vehicle> allVehicles;

        public TransportationHub(string name)
        {
            this.name = name;
            this.allRides = new List<Ride>();
            this.allVehicles = new List<Vehicle>();
        }

        //SAVES ALL RIDE OBJECTS
        public Exception SaveAllRides()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Rides.bin", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, allRides);

                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
            finally { if (fs != null) { fs.Close(); } }
        }

        //LOADS ALL RIDE OBJECTS
        public Exception LoadAllRides()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Rides.bin", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                allRides = (List<Ride>)bf.Deserialize(fs);
                return null;
            }
            catch (Exception ex)
            { return ex; }
            finally
            { if (fs != null) { fs.Close(); } }
        }

        //RETURNS LIST OF RIDES
        public List<Ride> GetAllRides()
        {
            return this.allRides;
        }

        //RESERVE RIDE
        public void ReserveRide(Vehicle vehicle, int amountOfPersons, double volumeOfCargo, double weightOfCargo, double priceOfRide, double startingPrice, int kilometers, DateTime startTime, DateTime? endTime)
        {
            Ride r = new Ride(vehicle, false, amountOfPersons, volumeOfCargo, weightOfCargo, priceOfRide, startingPrice, kilometers, startTime, endTime);
            allRides.Add(r);
        }

        //VEHICLES

        //SAVES ALL VEHICLES
        public Exception SaveAllVehicles()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Vehicles.bin", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, allVehicles);

                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
            finally { if (fs != null) { fs.Close(); } }
        }

        //LOADS ALL VEHICLES
        public Exception LoadAllVehicles()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Vehicles.bin", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                allVehicles = (List<Vehicle>)bf.Deserialize(fs);
                return null;
            }
            catch (Exception ex)
            { return ex; }
            finally
            { if (fs != null) { fs.Close(); } }


        }

        //RETURNS LIST OF ALL VEHICLES
        public List<Vehicle> GetAllVehicles()
        {
            allVehicles.Sort();
            return this.allVehicles;
        }

        //ADDS VEHICLE TO THE LIST OF VEHICLES
        public void AddVehicle(int ind, int maxPassengers, double maxWeight, double maxVolume, string makeAndModel, string licensePlate, double gasPerKM)
        {
            double gasPrice = 1.65;
            //SWITCH TO ADD THE CORRECT TYPE OF VEHICLE
            switch (ind)
            {
                case 0: Vehicle v1 = new Car("Car", maxPassengers, makeAndModel, licensePlate, gasPerKM, gasPrice * gasPerKM, 0, 0); allVehicles.Add(v1); break;
                case 1: Vehicle v2 = new Van("Van", maxPassengers, maxWeight, maxVolume, makeAndModel, licensePlate, gasPerKM, gasPrice * gasPerKM, 0, 0); allVehicles.Add(v2); break;
                case 2: Vehicle v3 = new Truck("Truck", maxWeight, maxVolume, makeAndModel, licensePlate, gasPerKM, gasPrice * gasPerKM, 0, 0); allVehicles.Add(v3); break;
                case -1: throw new NoVehicleTypeSelectedException();
            }
        }

        //GETS AN AVAILABLE VEHICLE TO RESERVE A RIDE
        public Vehicle GetAvailableVehicle(bool forPassengers, int amountOfPassenger, double volumeOfCargo, double weightOfCargo)
        {
            if(forPassengers == true)
            {
                foreach(Vehicle v in allVehicles)
                {
                    if ((v is Car && v.Available == true && ((Car)v).MaxPassenger >= amountOfPassenger) || v is Van && v.Available == true && ((Van)v).MaxPassenger >= amountOfPassenger)
                    {
                        return v;
                    }
                }
            }
            else
            {
                foreach(Vehicle v in allVehicles)
                {
                    if ((v is Truck && v.Available == true && ((Truck)v).MaxVolume >= volumeOfCargo) && ((Truck)v).MaxWeight >= weightOfCargo || v is Van && v.Available == true && ((Van)v).MaxVolume >= volumeOfCargo && ((Van)v).MaxWeight >= weightOfCargo)
                    {
                        return v;
                    }
                }
            }

            return null;
        }
        
    }
}
