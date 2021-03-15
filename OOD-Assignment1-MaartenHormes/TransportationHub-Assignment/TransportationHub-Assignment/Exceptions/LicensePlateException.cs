using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHub_Assignment
{
    public class LicensePlateException: Exception
    {
        public LicensePlateException(string licensePlate): base($"License plate ({licensePlate}) not informat 123-AB-4")
        {}
    }
}
