using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class IncorrectNumberInputException: Exception
    {
        public IncorrectNumberInputException(string number): base($"{number} is not in the correct format. Only numbers are accepted")
        {

        }
    }
}
