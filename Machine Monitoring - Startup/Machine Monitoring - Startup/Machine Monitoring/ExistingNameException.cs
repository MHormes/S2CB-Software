using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Monitoring
{
    public class ExistingNameException: Exception
    {
        public ExistingNameException(string name) : base($"There is already a machine with name {name}")
        {
        }
    }
}
