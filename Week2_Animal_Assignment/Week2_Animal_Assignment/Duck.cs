using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Animal_Assignment
{
    public class Duck: Animal
    {
        public Duck(string name): base(name)
        {
        }

        public override string speak()
        {
            return "Kuack";
        }
    }
}
