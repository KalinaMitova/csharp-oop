using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RawData
{
   public  class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;
        
        public Car(string model, 
            int engineSpeed, int enginePower,    int cargoWeight, string cargoType,
            double tire1Pressure, int tire1Age,  double tire2Pressure, int tire2Age,
            double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.model = model;

            this.engine = new Engine();
            engine.EngineSpeed = engineSpeed;
            engine.EnginePower = enginePower;

            this.cargo = new Cargo();
            cargo.CargoWeight = cargoWeight;
            cargo.CargoType = cargoType;

            this.tires = new Tire[4];
            Tire tire1 = new Tire
            {
               Pressure = tire1Pressure,
               Age = tire1Age
            };

            Tire tire2 = new Tire
            {
                Pressure = tire2Pressure,
                Age = tire2Age
            };

            Tire tire3 = new Tire
            {
                Pressure = tire3Pressure,
                Age = tire3Age
            };

            Tire tire4 = new Tire
            {
                Pressure = tire4Pressure,
                Age = tire4Age
            };

            tires[0] = tire1;
            tires[1] = tire2;
            tires[2] = tire3;
            tires[3] = tire4;
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public Engine Engine
        {
            get
            {
                return engine;
            }
        }

        public Cargo Cargo
        {
            get
            {
                return cargo;
            }
        }

        public Tire[] Tires
        {
            get
            {
                return tires;
            }
        }
    }
}
