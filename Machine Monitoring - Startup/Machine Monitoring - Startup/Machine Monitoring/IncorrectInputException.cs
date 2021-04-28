using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Monitoring
{
    public class IncorrectInputException: Exception
    {
        public IncorrectInputException(string input) : base($"{input} is not in correct format. Only numbers allowed")
        {

        }
    }
}
