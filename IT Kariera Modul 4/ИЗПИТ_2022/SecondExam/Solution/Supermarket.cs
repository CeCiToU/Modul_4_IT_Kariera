using System.Collections.Generic;
using System.Linq;

namespace Program
{
    internal class Supermarket
    {
        private string name;

        private List<Product> products = new List<Product>();

        public Supermarket(string name)
        {
            Name = name;
        }

        public string Name

        {

            get { return name; }
            set { this.name = value; }

        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }


        }

        public void AddProduct(string name, double price)
        {
            Product currentProduct = new Product(name, price);
            products.Add(currentProduct);
        }

        public double AveragePriceInRange(double start, double end)
        {
            double num = 0;
            for (int i = 0; i < products.Count; i++)
            {
                num += products[i].Price;
            }
            num /= products.Count;
            return num;
        }

        public List<string> FilterProductsByPrice(double price)
        {
            List<string> titles = new List<string>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price < price)
                {
                    titles.Add(products[i].Name);
                }
            }
            return titles;
        }

        public List<Product> SortAscendingByName()
        {
            return products = products.OrderBy(x => x.Name).ToList();
        }

        public List<Product> SortDescendingByPrice()
        {
            return products = products.OrderByDescending(x => x.Price).ToList();
        }

        public bool CheckProductIsInSupermarket(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] arr = new string[products.Count];
            for (int i = 0; i < products.Count; i++)
            {
                arr[i] = products[i].ToString();
            }
            return arr;
        }
    }
}