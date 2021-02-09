using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAnimals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public Cat(string name, int age): base(name, age)
        {
        }

        public override void CelebrateBirthday()
        {
            if (this.age < 25)
            {
                age++;
                return;
            }
            age = 25;
        }

        public override string ToString()
        {
            return $"Cat: {name} ({age} year)";
        }
    }
}
