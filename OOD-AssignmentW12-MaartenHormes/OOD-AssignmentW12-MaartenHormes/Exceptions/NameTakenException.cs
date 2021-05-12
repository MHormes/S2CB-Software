using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class NameTakenException: Exception
    {
        public NameTakenException(string name): base($"{name} is a name that is already taken. Please try something else")
        {

        }
    }
}
