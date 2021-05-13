using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class WorkshopStartedException: Exception
    {
        public WorkshopStartedException(): base("Workshop has already started")
        {

        }
    }
}
