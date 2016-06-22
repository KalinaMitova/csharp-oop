using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Define two classes Car and Engine. A Car has a model, engine, weight and color.An Engine 
// has model, power, displacement and efficiency. A Car’s weight and color and its Engine’s 
// displacements and efficiency are optional. 
//On the first line you will read a number N which will specify how many lines of engines you will receive, on 
// each of the next N lines you will receive information about an Engine in the following format
// “< Model > < Power > < Displacement > < Efficiency >”. After the lines with engines, on the next
// line you will receive a number M – specifying the number of Cars that will follow, on each of the
// next M lines information about a Car will follow in the following format “< Model > < Engine > 
// < Weight > < Color >”, where the engine in the format will be the model of an existing Engine.
// When creating the object for a Car, you should keep a reference to the real engine in it, instead 
// of just the engine’s model, note that the optional properties might be missing from the formats.
// Your task is to print each car(in the order you received them) and its information in the format
// defined bellow, if any of the optional fields has not been given print “n / a” in its place 
// instead:
//< CarModel >:< EngineModel >:Power: < EnginePower >Displacement: < EngineDisplacement >Efficiency: < EngineEfficiency >
//  Weight: < CarWeight > Color: < CarColor >
namespace _07PCarSalesman
{
    public class CarSalesman
    {
       public static void Main()
       {
            int numOfEngines = int.Parse(Console.ReadLine());
            List<Engine> AllInputEngines = new List<Engine>();

            for (int i = 0; i < numOfEngines; i++)
            {
                string[] inputEngines = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(inputEngines[0], int.Parse(inputEngines[1]));

                if (inputEngines.Length > 2)
                {
                    int displacement;
                    if (int.TryParse(inputEngines[2], out displacement))
                    {
                        engine.Displacements = inputEngines[2];
                    }
                    else
                    {
                        engine.Efficiancy = inputEngines[2];
                    }
                }
               if (inputEngines.Length > 3)
                {
                    engine.Efficiancy = inputEngines[3];
                }

                AllInputEngines.Add(engine);
            }

            int numOfCArs = int.Parse(Console.ReadLine());
            List<Car> AllInputCars = new List<Car>();

            for (int i = 0; i < numOfCArs; i++)
            {
                string[] inputCar = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(inputCar[0], inputCar[1]);

                if (inputCar.Length > 2)
                {
                    int weight;
                    if (int.TryParse(inputCar[2], out weight) )
                    {
                        car.Weight = inputCar[2];
                    }
                    else
                    {
                        car.Color = inputCar[2];
                    }     
                }
                if (inputCar.Length > 3)
                {
                    car.Color = inputCar[3];
                }

                AllInputCars.Add(car);
            }

                AllInputCars
                .Join(
                    AllInputEngines,
                    car => car.EnginesModel,
                    en => en.Model,
                    (car, en) => new
                    {
                        carModel = car.Model,
                        engModel = car.EnginesModel,
                        engPower = en.Power,
                        displ = en.Displacements,
                        effic = en.Efficiancy,
                        carWeight = car.Weight,
                        carColor = car.Color
                    }).ToList().ForEach(
                    c => Console.WriteLine($"{c.carModel}:\n  {c.engModel}:\n    Power: {c.engPower}\n    Displacement: {c.displ}\n    Efficiency: {c.effic}\n  Weight: {c.carWeight}\n  Color: {c.carColor}"));
        }
    }
}
