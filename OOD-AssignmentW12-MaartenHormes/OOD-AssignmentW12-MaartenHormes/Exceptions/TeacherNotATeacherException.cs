using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class TeacherNotATeacherException: Exception
    {
        public TeacherNotATeacherException() : base("The selected person is not a teacher. Please select a teacher to assign")
        {

        }
    }
}
