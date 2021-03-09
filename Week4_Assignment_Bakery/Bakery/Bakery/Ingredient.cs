using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [Serializable]
    public class Ingredient
    {
        public string Description
        {
            get; set;
        }

        public IngredientType IngredientType
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public Ingredient(string description, IngredientType ingredientType, double price)
        {
            Description = description;
            IngredientType = ingredientType;
            Price = price;
        }
    }

}
