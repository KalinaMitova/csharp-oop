using System;

namespace _01_Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
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
