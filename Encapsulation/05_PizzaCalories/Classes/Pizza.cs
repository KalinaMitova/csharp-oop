using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numOfToppings;

       public string Name
        {
            get
            {
               return this.name;
            }
            private set
            {
                if (value.Length <1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza {nameof(Name).ToLower()} should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public Dough DoughPizza
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public int NumOfToppings
        {
            get
            {
                return this.numOfToppings;
            }

            private set
            {
                if (value >10)
                {
                    throw new ArgumentException($"Number of toppings should be in range [0..10].");
                }
                this.numOfToppings = value;
            }
        }

        public Pizza (string name, int numOfToppings)
            {
            this.Name = name;
            this.NumOfToppings = numOfToppings;
            this.toppings = new List<Topping>();
            this.dough = new Dough();
            }

        public void AddTooping (Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetTotalCalories()
        {
            return CalculateTotalCalories();
        }
        private double CalculateTotalCalories()
        {
           double caloriesFromDough =  this.dough.GetCaloriesOfDough();
           double caloriesFromToppings = 0;

            foreach (var topping in this.toppings)
            {
                caloriesFromToppings += topping.GetCaloriesOfTopping();
            }

            return caloriesFromToppings + caloriesFromDough;
        }
    }
}
