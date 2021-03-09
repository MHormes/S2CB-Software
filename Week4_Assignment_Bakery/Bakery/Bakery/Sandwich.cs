using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [Serializable]
    public class Sandwich
    {

        public List<Ingredient> ingredients;

        public string Name
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public string NameAndPrice
        {
            get; set;
        }

        public Sandwich(string name, Bread bread)
        {
            Name = name;
            Price = bread.Price;
            NameAndPrice = $"{Name}-{Price}";
            ingredients = new List<Ingredient>();
        }

        public bool AddIngredient(Ingredient ingredient, out bool moreThan5)
        {
            if(ingredients.Count() == 5)
            {
                moreThan5 = false;
                return moreThan5;
            }
            else
            {
                moreThan5 = true;
            }
            
            foreach(Ingredient ig in ingredients)
            {
                if(ig.Description == ingredient.Description)
                {
                    return false;                    
                }
            }
            ingredients.Add(ingredient);
            return true;
            
        }
    }
}
