using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Bread
    {
        public string Description
        {
            get; set;
        }

        public BreadType BreadType
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public Bread(string description, BreadType breadType, double price)
        {
            Description = description;
            BreadType = breadType;
            Price = price;
        }
    }
}
