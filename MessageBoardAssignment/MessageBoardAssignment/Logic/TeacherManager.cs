using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace MessageBoardAssignment
{
    public class TeacherManager
    { 

        public Teacher CurrentTeacher
        {
            get; set;
        }

        public bool SetCurrentTeacher(string fullName, string classTeached)
        {
            if(Regex.IsMatch(classTeached, @"^[1-8]{1}$"))
            {
                CurrentTeacher = new Teacher(fullName, Convert.ToInt32(classTeached));
                return true;
            }
            return false;
        }
    }
}
