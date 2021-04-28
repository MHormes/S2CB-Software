using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Webshop
{
    public class WebshopLogic
    {
        private List<Product> products;

        public delegate void AddingNewProductHandler(Product newProduct);
        public delegate void UpdateOldProductHandler(Product oldProduct);

        public event AddingNewProductHandler AddingProductEvent;
        public event UpdateOldProductHandler UpdateProductEvent;

        public WebshopLogic()
        {
            products = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return this.products;
        }

        public Product GetProduct(string name)
        {
            foreach(Product p in products)
            {
                if(p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }

        public Exception AddNewProduct(string name, string price, ProductType productType, string stock)
        {
            try
            {
                CheckCorrectInput(name, price, stock);
                Product newProduct = new Product(name, Convert.ToDouble(price), productType, Convert.ToInt32(stock));
                products.Add(newProduct);

                if (AddingProductEvent != null)
                {
                    AddingProductEvent(newProduct);
                }

                return null;
            }
            catch(IncorrectInputException exNumber)
            {
                return exNumber;
            }
            catch(ExcistingNameException exName)
            {
                return exName;
            }
        }

        public Exception EditOldProduct(Product product, string name, string price, ProductType productType, string stock)
        {
            try
            {
                if (!Regex.IsMatch(price, @"^[0-9]*$"))
                {
                    throw new IncorrectInputException(price);
                }

                if (!Regex.IsMatch(stock, @"^[0-9]*$"))
                {
                    throw new IncorrectInputException(stock);
                }
                product.Name = name;
                product.Price = Convert.ToDouble(price);
                product.productType = productType;
                product.Stock = Convert.ToInt32(stock);

                if (UpdateProductEvent != null)
                {
                    UpdateProductEvent(product);
                }
                return null;
            }
            catch (IncorrectInputException exNumber)
            {
                return exNumber;
            }
            catch (ExcistingNameException exName)
            {
                return exName;
            }
        }

        public bool PurhcaseProduct(Product product, int amount)
        {
            Product toSell = product;
            if(toSell.Stock < amount)
            {
                return false;
            }
            toSell.Stock -= amount;
            if (UpdateProductEvent != null)
            {
                UpdateProductEvent(product);
            }
            return true;
        }

        public void CheckCorrectInput(string name, string price, string stock)
        {
            if (GetProduct(name) != null)
            {
                throw new ExcistingNameException(name);
            }

            if (!Regex.IsMatch(price, @"^[0-9]*$"))
            {
                throw new IncorrectInputException(price);
            }

            if (!Regex.IsMatch(stock, @"^[0-9]*$"))
            {
                throw new IncorrectInputException(stock);
            }
        }
    }
}
