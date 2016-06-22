using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//car’s Model, fuel amount, fuel cost for 1 kilometer and distance traveled.
namespace _05SpeedRacing
{
   public class Car
    {
        public void GetDistanceTraveledAndLeftFuel(int distanceToTravel)
            {
            decimal neededFuel = fuelCoustPerKm * distanceToTravel;
                if (neededFuel > fuelAmount)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                 else
                    {
                        fuelAmount -= neededFuel;
                        distanceTraveled += distanceToTravel;
                    }
            }

        private string model;
        private decimal fuelAmount;
        private decimal fuelCoustPerKm;
        private int distanceTraveled;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public decimal FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                fuelAmount = value;
            }
        }

        public decimal FuelCoustPerKm
        {
            get
            {
                return fuelCoustPerKm;
            }
            set
            {
                fuelCoustPerKm = value;
            }
        }
        public int DistanceTraveled
        {
            get
            {
                return distanceTraveled;
            }
            set
            {
                distanceTraveled = value;
            }
        }
    }
}
