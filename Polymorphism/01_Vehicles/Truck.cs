
namespace _01_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            base.FuelConsumption = fuelConsumption + 1.6;
        }

        public override void GetFuelAfterRefuel(double fuel)
        {
            base.FuelQuantity += fuel*0.95;
        }
    }
}
