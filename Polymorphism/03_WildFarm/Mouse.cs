using System;

namespace _03_WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, double animalWeight, string livingRegion) 
            : base("Mouse", animalName, animalWeight, livingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                throw new ArgumentException($"{this.AnimalType}s are not eating that type of food!");
            }
            else
            {
                base.EatFood(food);
            }
        }

        public override string MakeSound()
        {
            return $"SQUEEEAAAK!";
        }
    }
}
