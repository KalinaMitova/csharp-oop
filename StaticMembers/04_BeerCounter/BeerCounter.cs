using System;
using System.Linq;


//Define class BeerCounter holding static field beerInStock that shows how many beers you bought and static field beersDrankCount that shows 
//how many beers you have drunk.Manipulate the static fields through static methods BuyBeer(int bottlesCount) and DrinkBeer(int bottlesCount).
//On every input line you will get pair of beers you bought and beers you drank, until you receive command “End”. 
//  BuyBeer – add beers to the beers in stock
//  DrinkBeer – add beers to the drunk beers counter and subtract beers in stock
//  After that print beersInStock and beersDrankCount on the same line separated by 1 space.

namespace _04_BeerCounter
{
    public class BeerCounter
    {
        public static int beerInStock;
        public static int beersDrankCount;

        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }
        public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount += bottlesCount;
            beerInStock -= bottlesCount; 
        }
    }
   public class BeerCounters
    {
       public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                int[] beerData = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                BeerCounter.BuyBeer(beerData[0]);
                BeerCounter.DrinkBeer(beerData[1]);

                input = Console.ReadLine();
            }

            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beersDrankCount}");
        }
    }
}
