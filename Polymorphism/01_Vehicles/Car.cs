using System;

namespace _01_Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            base.FuelConsumption = fuelConsumption + 0.9;
        }

        public override void GetFuelAfterRefuel(double fuel)
        {
            if (fuel > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.FuelQuantity += fuel;
            }
        }
    }
}
