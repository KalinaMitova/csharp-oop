using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ShoppingSpree
{
   internal class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfPruducts;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace( value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Money)} cannot be negative");

                }
                this.money = value;
            }
        }

        public List<Product> BagOgProducts => this.bagOfPruducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfPruducts = new List<Product>();
        }

        public string AddProductToBag (Product product)
        {
            if (product.Cost <= this.money)
            {
                this.money -= product.Cost;
                this.bagOfPruducts.Add(product);

                return $"{this.Name} bought {product.Name}";

            }
            else
            {
               return $"{this.Name} can't afford {product.Name}";
            }
        }

    }
}
