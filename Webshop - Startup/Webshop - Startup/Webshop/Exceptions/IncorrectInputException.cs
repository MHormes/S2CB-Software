using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class IncorrectInputException: Exception
    {
        public IncorrectInputException(string input) : base($"input: {input} is not in the correct format")
        {

        }
    }
}
