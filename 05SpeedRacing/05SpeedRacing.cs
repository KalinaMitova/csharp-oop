using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SpeedRacing
{
   public class Program
    {
        public static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car
                {
                    Model = inputCar[0],
                    FuelAmount = decimal.Parse(inputCar[1]),
                    FuelCoustPerKm = decimal.Parse(inputCar[2])
                };

                cars.Add(car);
            }
            string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "End")
            {
                foreach (var car in cars)
                {
                    if (car.Model == command[1])
                    {
                        car.GetDistanceTraveledAndLeftFuel(int.Parse(command[2]));
                        break;
                    } 
                }

                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join("\n", cars.Select(x => $"{x.Model} {x.FuelAmount:F2} {x.DistanceTraveled}")));
        }
    }
}
