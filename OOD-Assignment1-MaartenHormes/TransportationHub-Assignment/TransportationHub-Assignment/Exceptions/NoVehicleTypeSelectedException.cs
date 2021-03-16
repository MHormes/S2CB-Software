using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHub_Assignment
{
    public class NoVehicleTypeSelectedException: Exception
    {
        public NoVehicleTypeSelectedException() : base("Please select a vehicle type")
        {

        }
    }
}
