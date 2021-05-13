using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class TeacherAlreadyAssignedExcpetion: Exception
    {
        public TeacherAlreadyAssignedExcpetion(): base("Teacher is already assigned. Please select someone else")
        {

        }
    }
}
