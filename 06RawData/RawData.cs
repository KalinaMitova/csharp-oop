using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RawData
{
    public class RawData
    {
       public static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(carInput[0],
                    int.Parse(carInput[1]), int.Parse(carInput[2]), 
                    int.Parse(carInput[3]), carInput[4], 
                    double.Parse(carInput[5]), int.Parse(carInput[6]), 
                    double.Parse(carInput[7]), int.Parse(carInput[8]),
                    double.Parse(carInput[9]), int.Parse(carInput[10]),
                    double.Parse(carInput[11]), int.Parse(carInput[12]));

                cars.Add(car);
            }

            string command = Console.ReadLine().Trim();

            switch (command)
            {
                case "fragile":
                    Console.WriteLine(string.Join("\n", cars.Where(x => x.Tires.Any(c => c.Pressure <1) && x.Cargo.CargoType == "fragile").Select(c => c.Model)));
                    ; break;

                case "flamable":
                    Console.WriteLine(string.Join("\n", cars.Where(x => x.Engine.EnginePower > 250 && x.Cargo.CargoType == "flamable").Select(c => c.Model)));
                    break;
            }
        }
    }
}
