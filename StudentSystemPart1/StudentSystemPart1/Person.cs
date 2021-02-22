using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemPart1
{
    abstract public class Person
    {
        protected int age;
        protected string name;
        protected int pcn;
        protected int yearsAtSchool;

        public Person(int age, string name, int pcn, int yearsAtSchool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
        }

        public int GetPcn()
        {
            return pcn;
        }

        public string GetName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return $"{name} : {age} year, pcn: {pcn}, at school for {yearsAtSchool} year";
        }

        public void CelebrateBirthday()
        {
            this.age++;
        }

        public void StartAnotherSchoolyear()
        {
            yearsAtSchool++;
        }
    }
}
