using System;
using System.Collections.Generic;

//Define two classes: Animal(name, breed) and AnimalClinic(static field patientId, static field healedAnimalsCount and static field 
//rehabilitedAnimalsCount). You will be given animal data(name and breed) and information whether the animal should be healed or rehabilitated.
//Keep track on the rehabilitated animals, on the healed animals and overall patients.If the animal has been healed, you need to print on the 
//console the following message:
//Patient { patientID}
//[{name} ({breed})] has been healed!
//Otherwise print:
//Patient {patientID} [{name} ({breed})] has been rehabilitated!
//You will receive information about animals until you receive command “End”.
//After you receive command “End” print total healed animals and total rehabilitated animals in format:
//Total healed animals: {count}
//Total rehabilitated animals: {count}
//After that you will receive one of the following commands heal or rehabilitate and you must print all the names and breed of the healed or 
//rehabilitated animals in format {name} {breed} each animal on new line.

namespace _05_AnimalClinic
{
    public class Animal
    {
        private string name;
        private string breed;

        public string Name => this.name;
        public string Breed => this.breed;


        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public override string ToString()
        {
            return $"{this.name} {this.breed}";
        }
    }

    public class AnimalClinic
    {
       private static int patientId;
       private static List<Animal> healedAnimalsCount;
       private static List<Animal> rehabilitedAnimalsCount;

        public static int PatienID => patientId;

        public static List<Animal> HealedAnimalsCount => healedAnimalsCount;
        public static List<Animal> RehabilitedAnimalsCount => rehabilitedAnimalsCount;

        static AnimalClinic()
            {
            healedAnimalsCount = new List<Animal>();
            rehabilitedAnimalsCount = new List<Animal>();
            }

        public static void AddToHealedAnimals(Animal animal)
        {
            patientId++;
            healedAnimalsCount.Add(animal);
        }

        public static void AddToRehabilitedAnimals(Animal animal)
        {
            patientId++;
            rehabilitedAnimalsCount.Add(animal);
        }
    }


    public class Program
    {
       public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] dataInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = new Animal(dataInput[0], dataInput[1]);
                if (dataInput[2] == "rehabilitate")
                {
                    dataInput[2] = "rehabilitat";
                    AnimalClinic.AddToRehabilitedAnimals(animal);
                }
                else if (dataInput[2] == "heal")
                {
                    AnimalClinic.AddToHealedAnimals(animal);
                }

                Console.WriteLine($"Patient {AnimalClinic.PatienID}: [{animal.Name} ({animal.Breed})] has been {dataInput[2]}ed!");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total healed animals: {AnimalClinic.HealedAnimalsCount.Count}\nTotal rehabilitated animals: { AnimalClinic.RehabilitedAnimalsCount.Count}");

           string command = Console.ReadLine().Trim();

            switch (command)
            {
                case "heal":
                    {
                        foreach (var an in AnimalClinic.HealedAnimalsCount)
                        {
                            Console.WriteLine(an);
                        }
                    }
                    break;

                case "rehabilitate":
                    {
                        foreach (var an in AnimalClinic.RehabilitedAnimalsCount)
                        {
                            Console.WriteLine(an);
                        }
                    }
                    break;
            }


        }
    }
}
