using System;

namespace _03_WildFarm
{
    public class Tiger : Felime
    {
        public Tiger(string animalName, double animalWeight, string livingRegion) 
            : base("Tiger", animalName, animalWeight, livingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name == "Vegetable")
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
            return $"ROAAR!!!";
        }
    }
}
