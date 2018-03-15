using System;
using System.Collections.Generic;

namespace _03_Mordor_sCrueltyPlan
{
  public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().
                Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            List<FoodFactory> foods = new List<FoodFactory>();

            int moonPoints = 0;

            foreach (var str in input)
            {
                 switch (str.ToLower())
                 {

                     case "cram":
                         {
                             Cram cram = new Cram(str);
                             foods.Add(cram);
                             moonPoints += Cram.HappinessPoints;
                         }
                         break;

                     case "lembas":
                         {
                             Lembas lembas = new Lembas(str);
                             foods.Add(lembas);
                             moonPoints += Lembas.HappinessPoints;
                         }
                         break;

                     case "apple":
                         { 
                             Apple apple = new Apple(str);
                             moonPoints += Apple.HappinessPoints;
                             foods.Add(apple);
                         }
                         break;

                     case "melon":
                         {
                             Melon melon = new Melon(str);
                             foods.Add(melon);
                             moonPoints += Melon.HappinessPoints;
                         }
                         break;

                     case "honeycake":
                         {
                             HoneyCake honeyCake = new HoneyCake(str);
                             moonPoints += HoneyCake.HappinessPoints;
                             foods.Add(honeyCake);
                         }
                         break;
                     case "mushrooms":
                         {
                             Mushrooms mushrooms = new Mushrooms(str);
                             foods.Add(mushrooms);                             
                             moonPoints += Mushrooms.HappinessPoints;

                         }
                         break;
                     default:
                         {
                             FoodFactory food = new FoodFactory(str);
                             moonPoints += FoodFactory.HappinessPoints;
                             foods.Add(food);
                         }
                         break;
                 }
            }

            MoodFactory mood = new MoodFactory(moonPoints);

            Console.WriteLine(mood); 
        }
    }
}
