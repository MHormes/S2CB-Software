using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemPart1
{
    public class Student: Person
    {
        private int nrOfECs;

        public Student(int age, string name, int pcn, int yearsAtSchool): base(age, name, pcn, yearsAtSchool)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()}, EC's: {nrOfECs}";
        }

        public void AddECs(int n)
        {
            nrOfECs += n;
        }
    }
}
