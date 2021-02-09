using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAnimals
{
    public class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name)
        {
            this.name = name;
            this.age = 1;
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void CelebrateBirthday()
        {
            if(this.age < 100)
            {
                age++;
                return;
            }
            age = 100;
        }

        public override string ToString()
        {
            return $"{name} ({age} year)";
        }
    }
}
