using System;

namespace _05_PizzaCalories
{
   public  class Topping
    {
        static int caloriesBasicPerGram = 2;
        static double meatFactor = 1.2;
        static double veggiesFactor = 0.8;
        static double cheeseFactor = 1.1;
        static double sauceFactor = 0.9;

        private string type;
        private double weight;

        public string Type
        {
            get { return this.type; }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value.ToString()} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} {nameof(Weight).ToLower()} should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double GetCaloriesOfTopping()
        {
            return CalculateCalories();
        }
        private double CalculateCalories()
        {
            double toppingFactor = 0;

            switch (this.Type.ToLower())
            {
                case "meat": toppingFactor = meatFactor; break;
                case "veggies": toppingFactor = veggiesFactor; break;
                case "cheese": toppingFactor = cheeseFactor; break;
                case "sauce": toppingFactor = sauceFactor; break;
            }

            return this.Weight * caloriesBasicPerGram * toppingFactor;
        }
    }
}
