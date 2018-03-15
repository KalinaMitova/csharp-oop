using System;

namespace _01_Vehicles
{
    public abstract class Vehicle
    {
        public double FuelConsumption { get; protected set; }
        private double fuelQuantity;
        public double TankCapacity { get; }


        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get {return this.fuelQuantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Fuel must be a positive number");
                }

                this.fuelQuantity = value;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }

        public string GetDrivedDistance(double distance, string fullOrEmpty = null)
        {
            if (fullOrEmpty == "full" )
            {
                this.FuelConsumption += 1.4;
            }
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }

        }

        public abstract void GetFuelAfterRefuel(double fuel);

    }
}
