using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public ProductType productType { get; set; }

        public int Stock { get; set; }

        public Product(string name, double price, ProductType productType, int stock)
        {
            Name = name;
            Price = price;
            this.productType = productType;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Type: {productType}, Stock: {Stock}";
        }
    }
}
