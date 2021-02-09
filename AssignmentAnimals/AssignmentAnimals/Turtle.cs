using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAnimals
{
    public class Turtle: Animal
    {
        public Turtle(string name) : base(name)
        {
        }

        public Turtle(string name, int age) : base(name, age)
        {
        }

        public override string ToString()
        {
            return $"Turtle: {name} ({age} year)";
        }
    }
}
