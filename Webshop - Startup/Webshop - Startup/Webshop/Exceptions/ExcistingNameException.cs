using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class ExcistingNameException: Exception
    {
        public ExcistingNameException(string input): base($"Name: {input} already exists")
        {

        }
    }
}
