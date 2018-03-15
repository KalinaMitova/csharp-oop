using System;


namespace _04_ShoppingSpree
{
   internal class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if  (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get { return this.cost; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");

                }
                this.cost = value;
            }
        }

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }
}
