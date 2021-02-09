using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAnimals
{
    public class Dog: Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void CelebrateBirthday()
        {
            if (this.age < 20)
            {
                age++;
                return;
            }
            age = 20;
        }

        public override string ToString()
        {
            return $"Dog: {name} ({age} year)";
        }
    }
}
