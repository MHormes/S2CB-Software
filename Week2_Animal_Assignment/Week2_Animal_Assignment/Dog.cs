using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Animal_Assignment
{
    public class Dog: Animal
    {
        public Dog(string name): base(name)
        {
        }

        public override string speak()
        {
            return "Woof";
        }
    }
}
