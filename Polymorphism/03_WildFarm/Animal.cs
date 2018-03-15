using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WildFarm
{
    public abstract class Animal
    {
        public string AnimalName { get; }
        public string AnimalType {get; }
        public double AnimalWeight { get; }
        public  int FoodEaten { get; protected set; }

        public Animal(string animalType, 
                      string animalName,
                      double animalWeight)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
        }

        public abstract string MakeSound();
        public virtual void EatFood(Food food)
        {
            if (food.Quantity > 0)
            {
                this.FoodEaten += food.Quantity;

            }
        }  
    }
}
