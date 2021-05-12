using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class DateBeforeNowException: Exception
    {
        public DateBeforeNowException(DateTime date) : base($"{date} is in the past. Nice try tho ;p")
        {

        }
    }
}
