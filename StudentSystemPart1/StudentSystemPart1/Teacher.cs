using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemPart1
{
    public class Teacher: Person
    {
        private JobPosition position;
        private double salary;

        public Teacher(int age, string name, int pcn, int yearsAtSchool): base(age,name,pcn,yearsAtSchool)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void MakePromotion()
        {
            if(position != JobPosition.DIRECTOR)
            {
                position++;
            }
        }
    }
}
