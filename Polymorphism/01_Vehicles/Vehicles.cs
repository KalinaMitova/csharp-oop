using System;

namespace _01_Vehicles
{
    public class Vehicles
    {
        public static void Main()
        {
            string[] carData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double fuel = double.Parse(carData[1]);
            double fuelConsum = double.Parse(carData[2]);
            double taskCapacity = double.Parse(carData[3]);
            Vehicle car = new Car(fuel, fuelConsum, taskCapacity);

            string[] truckData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            fuel = double.Parse(truckData[1]);
            fuelConsum = double.Parse(truckData[2]);
            taskCapacity = double.Parse(truckData[3]);
            Vehicle truck = new Truck(fuel, fuelConsum,taskCapacity);

            string[] bussData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            fuel = double.Parse(bussData[1]);
            fuelConsum = double.Parse(bussData[2]);
            taskCapacity = double.Parse(bussData[3]);
            Vehicle buss = new Bus(fuel, fuelConsum, taskCapacity);

            int numOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfRows; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string vehicle = input[1];
                double fuelOrDistance = double.Parse(input[2]);

                switch (command)
                {
                    case "Refuel":
                        {
                            if (vehicle == "Car")
                            {
                                car.GetFuelAfterRefuel(fuelOrDistance);
                            }
                            else if (vehicle == "Truck")
                            {
                                truck.GetFuelAfterRefuel(fuelOrDistance);
                            }
                            else if (vehicle == "Bus")
                            {
                                buss.GetFuelAfterRefuel(fuelOrDistance);
                            }

                        }
                        break;

                    case "Drive":
                        {
                            if (vehicle == "Car")
                            {
                                Console.WriteLine(car.GetDrivedDistance(fuelOrDistance));
                            }
                            else if (vehicle == "Truck")
                            {
                                Console.WriteLine(truck.GetDrivedDistance(fuelOrDistance));
                            }
                            else if (vehicle == "Bus")
                            {
                                Console.WriteLine(buss.GetDrivedDistance(fuelOrDistance, "full"));
                            }
                        }
                        break;

                    case "DriveEmpty":
                        {
                            Console.WriteLine(buss.GetDrivedDistance(fuelOrDistance));
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(buss);
        }
    }
}
