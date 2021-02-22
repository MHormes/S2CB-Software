using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Animal_Assignment
{
    abstract public class Animal
    {
        protected string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract string speak();

        public override string ToString()
        {
            return Name;
        }
    }
}
