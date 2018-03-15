using System;

namespace _03_WildFarm
{
   public class WildFarm
    {
       public static void Main()
        {
            string[] dataAnimal = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (dataAnimal[0] != "End")
            {
                string[] foodData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string animalType = dataAnimal[0].ToLower();
                string animalName = dataAnimal[1];
                double animalWeight = double.Parse(dataAnimal[2]);
                string catBreed = null;
                string livingRegion = null;

                if (dataAnimal.Length == 5)
                {
                    catBreed = dataAnimal[3];
                    livingRegion = dataAnimal[4];
                }
                else
                {
                    livingRegion = dataAnimal[3];
                }
                Animal animal = new Cat("",0.0,"","");
                switch (animalType)
                {                    
                    case "cat":
                        {
                            animal = new Cat(animalName, animalWeight, livingRegion, catBreed);
                        }
                        break;

                    case "tiger":
                        {
                            animal = new Tiger(animalName, animalWeight, livingRegion);
                        }
                        break;

                    case "mouse":
                        {
                            animal = new Mouse(animalName, animalWeight, livingRegion);
                        }
                        break;

                    case "zebra":
                        {
                            animal = new Zebra(animalName, animalWeight, livingRegion);
                        }
                        break;
                }

                Console.WriteLine(animal.MakeSound());

                string foodType = foodData[0].ToLower();
                int foodQuantity = int.Parse(foodData[1]);
                Food food = new Vegetable(0);

                if (foodType == "vegetable")
                {
                    food = new Vegetable(foodQuantity);
                }
                else if (foodType == "meat")
                {
                    food = new Meat(foodQuantity);
                }
                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
                Console.WriteLine(animal);

                dataAnimal = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
