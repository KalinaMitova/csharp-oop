using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Car. Every car has a speed, fuel and fuel economy (given in the same order on the first line). They should be stored in the class. 
//Your task is to create a program which executes one of the commands:
//•	Travel <distance> – makes the car travel the specified<distance>
//If you are given a distance which you don't have enough fuel to travel, just go as far as you can.
//•	Refuel<liters> – refuels the car with the specified <fuel>
//•	Distance – gets the total travel distance
//•	Time – get the total travel time
//•	Fuel – gets the remaining fuel
//•	END – stops the program

namespace _08_Car
{
    public class Car
    {
        private int speed;
        private double fuel;
        private int fuelConsumption;
        private double traveledDistance;
        private int timeMin;

        public int Speed => this.speed;
        public double Fuel => this.fuel;
        public int FuelConsumption => this.fuelConsumption;
        

        public Car(int speed, double fuel, int fuelConsumption)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelConsumption = fuelConsumption;
        }

        public void GetTraveledDistance(double distance)
        {
            double needeFuel = (this.fuelConsumption / 100d) * distance;

            if (needeFuel > this.fuel && fuel >0)
            {
                distance = (100d / this.fuelConsumption) * fuel;
            }
            else if (needeFuel > this.fuel && fuel == 0)
            {
                distance = 0;
            }

            this.timeMin +=(int) ((distance / this.speed) * 60);
            this.traveledDistance += distance;
            this.fuel -= (this.fuelConsumption / 100d) * distance;
        }

        public double Refuel(double fuel)
        {
            return this.fuel += fuel;
        }

        public string PrintTotalTraveledDistance()
        {
            return $"Total distance: {this.traveledDistance:F1} kilometers";
        }

        public string PrintTotalTraveledTime()
        {
            int hours = timeMin / 60;
            int min = timeMin % 60;
            return $"Total time: {hours} hours and {min} minutes";
        }

        public string PrintRemainingFuel()
        {
            return $"Fuel left: {fuel:F1} liters";
        }

    }

    public class CarState
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(int.Parse(input[0]), double.Parse(input[1]), int.Parse(input[2]));
            string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Travel": car.GetTraveledDistance(double.Parse(command[1])); break;
                    case "Refuel": car.Refuel(double.Parse(command[1])); break;
                    case "Distance": Console.WriteLine(car.PrintTotalTraveledDistance()); break;
                    case "Time": Console.WriteLine(car.PrintTotalTraveledTime()); break;
                    case "Fuel": Console.WriteLine(car.PrintRemainingFuel()); break;
                }

                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
