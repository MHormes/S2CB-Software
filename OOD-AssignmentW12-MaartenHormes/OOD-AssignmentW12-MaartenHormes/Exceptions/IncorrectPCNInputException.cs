using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class IncorrectPCNInputException: Exception
    {
        public IncorrectPCNInputException(string pcn): base($"PCN:{pcn} is not in the correct format. 6 digit numbers allowed only")
        {

        }
    }
}
