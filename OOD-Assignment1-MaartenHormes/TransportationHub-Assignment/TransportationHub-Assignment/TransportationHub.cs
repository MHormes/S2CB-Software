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
    public class TransportationHub
    {
        private string name;
        private List<Ride> rides;
        private List<Ride> completedRides;
        private List<Vehicle> allVehicles;

        public TransportationHub(string name)
        {
            this.name = name;
            this.rides = new List<Ride>();
            this.completedRides = new List<Ride>();
            this.allVehicles = new List<Vehicle>();
        }

        public List<Ride> GetRides()
        {
            return this.rides;
        }

        public List<Ride> GetCompletedRides()
        {
            return this.completedRides;
        }

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

        public List<Vehicle> GetAllVehicles()
        {
            allVehicles.Sort();
            return this.allVehicles;
        }

        public void AddVehicle(int ind, int maxPassengers, double maxWeight, double maxVolume, string makeAndModel, string licensePlate, double gasPerKM)
        {
            switch (ind)
            {
                case 0: Vehicle v1 = new Car(false, maxPassengers, makeAndModel, licensePlate, gasPerKM, 100 / gasPerKM, 0, 0); allVehicles.Add(v1); break;
                case 1: Vehicle v2 = new Van(false, maxPassengers, maxWeight, maxVolume, makeAndModel, licensePlate, gasPerKM, 100 / gasPerKM, 0, 0); allVehicles.Add(v2); break;
                case 2: Vehicle v3 = new Truck(false, maxWeight, maxVolume, makeAndModel, licensePlate, gasPerKM, 100 / gasPerKM, 0, 0); allVehicles.Add(v3); break;
            }
        }


        public void ReserveRide()
        {

        }
    }
}
