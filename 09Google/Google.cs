using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

//Google is always watching you, so it should come as no surprise that they know everything about you(even your pokemon collection)
//, since you’re really good at writing classes Google asked you to design a Class that can hold all the information they need for
//people.
//From the console you will receive an unkown amount of lines until the command “End” is read, on each of those lines there will be
//information about a person in one of the following formats:
//•	“<Name> company<companyName> <department> <salary>”  
//•	“<Name> pokemon<pokemonName> <pokemonType>”
//•	“<Name> parents<parentName> <parentBirthday>”
//•	“<Name> children<childName> <childBirthday>”
//•	“<Name> car<carModel> <carSpeed>”
//You should structure all information about a person in a class with nested subclasses.People’s names are unique - there won’t 
//be 2 people with the same name, a person can also have only 1 company and car, but can have multiple parents, chidlren and 
//pokemon.After the command “End” is received on the next line you will receive a single name, you should print all information 
//about that person. Note that information can change during the input, for instance if we receive multiple lines which specify a 
//person’s company, only the last one should be the one remembered.The salary must be formated to two decimal places after the 
//seperator.

namespace _09Google
{
   public class Google
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Pokemon> pokemons = new List<Pokemon>();
            List<Children> children = new List<Children>();
            List<Parent> parents = new List<Parent>();
            List<Company> companies = new List<Company>();
            List<Car> cars = new List<Car>();

            while (input[0] != "End")
            {
                switch (input[1])
                {
                    case "company":
                        {
                            Company company = new Company(input[0], input[2], input[3], double.Parse(input[4]));
                            companies.Add(company);
                        }
                        break;
                    case "parents":
                        { 
                            Parent parent = new Parent(input[0], input[2], input[3]);
                            parents.Add(parent);
                        }
                        break;
                    case "children":
                        {
                            Children child = new Children(input[0], input[2], input[3]);
                            children.Add(child);
                        }
                        break;
                    case "car":
                        {
                            Car car = new Car(input[0], input[2], double.Parse(input[3]));
                            cars.Add(car);
                        }
                        break;
                    case "pokemon":
                        {
                            Pokemon pokemon = new Pokemon(input[0], input[2], input[3]);
                            pokemons.Add(pokemon);
                        }
                        break;
                }

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var childrenGr = children.GroupBy(c => c.MainName);
            var carsGr = cars.GroupBy(c => c.OwnerName);
            var parentsGr = parents.GroupBy(p => p.MainName);
            var companiesGr = companies.GroupBy(c => c.MainName);
            var pokemonsGr = pokemons.GroupBy(p => p.OwnerName);

            string name = Console.ReadLine().Trim();

            Console.WriteLine($"{name}");

            Console.WriteLine($"Company:");

            foreach (var na in companiesGr)
            {
                if (na.Key == name)
                {
                    Console.WriteLine($"{na.LastOrDefault()}");
                    break;
                }
            }
            Console.WriteLine($"Car:");

            foreach (var car in carsGr)
            {
                if (car.Key == name)
                {
                    Console.WriteLine($"{car.LastOrDefault()}");
                    break;
                }
            }

            Console.WriteLine($"Pokemon:");

            foreach (var nm in pokemonsGr)
            {
                if (nm.Key == name)
                {
                    foreach (var poc in nm)
                    {
                        Console.WriteLine($"{poc}");
                    }  
                    break;
                }
            }
            Console.WriteLine($"Parents:");

            foreach (var nm in parentsGr)
            {
                if (nm.Key == name)
                {
                    foreach (var par in nm)
                    {
                        Console.WriteLine($"{par}");
                    }
                    break;
                }
            }

            Console.WriteLine($"Children:");

            foreach (var nm in childrenGr)
            {
                if (nm.Key == name)
                {
                    foreach (var child in nm)
                    {
                        Console.WriteLine($"{child}");
                    }
                    break;
                }
            }
        }
    }
}
