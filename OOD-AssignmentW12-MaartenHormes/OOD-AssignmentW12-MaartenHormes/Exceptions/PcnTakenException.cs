using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class PcnTakenException: Exception
    {
        public PcnTakenException(string pcn): base($"PCN:{pcn} is already taken")
        {

        }
    }
}
