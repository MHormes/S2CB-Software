using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardAssignment
{
    public class Teacher
    {

        public int ClassTeached
        {
            get; set;
        }

        public string FullName
        {
            get; set;
        }

        public Teacher(string fullName, int classTeached)
        {
            FullName = fullName;
            ClassTeached = classTeached;
        }
    }
}
