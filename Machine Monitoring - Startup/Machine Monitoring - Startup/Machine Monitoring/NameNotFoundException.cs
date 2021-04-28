using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Monitoring
{
    public class NameNotFoundException: Exception
    {
        public NameNotFoundException(string name) : base($"{name} could not be found")
        {

        }
    }
}
