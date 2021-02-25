using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Candy
{
    class Candy : IComparable<Candy>
    {
        // Fields
        private double price;
        private string name;

        // Properties
        public double Price 
        {
            get { return this.price; }
            set { this.price = value;} 
        }

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; } 
        }
        // Methods
        public Candy(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetInfo()
        {
            return $"{Name}: ${Price}";
        }

        public int CompareTo(Candy other)
        {
            if(other.Price > Price) { return -1; }
            else if (other.Price < Price) { return 1; }
            else
            {
                return String.Compare(this.Name, other.Name);
            }
        }

    }
}
