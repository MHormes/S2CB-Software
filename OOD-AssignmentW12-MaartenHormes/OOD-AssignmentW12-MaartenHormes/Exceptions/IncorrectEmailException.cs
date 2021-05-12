using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class IncorrectEmailException: Exception
    {
        public IncorrectEmailException(string email): base($"Email: {email} is not a valid email adress")
        {

        }
    }
}
