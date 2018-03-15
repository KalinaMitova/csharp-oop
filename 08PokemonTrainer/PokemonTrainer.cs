using System;
using System.Collections.Generic;
using System.Linq;

namespace _08PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Pokemon> pokemons = new List<Pokemon>();

            while (input != "Tournament")
            {
                string[] trainerPokemonInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Pokemon pokemon = new Pokemon(trainerPokemonInput[0], trainerPokemonInput[1], trainerPokemonInput[2], decimal.Parse(trainerPokemonInput[3]));
                pokemons.Add(pokemon);    

                input = Console.ReadLine();
            }
            
            var pocemonsByTrainer = pokemons.
                GroupBy(p => p.NameTrainer).
                Select(tr => new
                {
                    trName = tr.Key,
                    poc = tr.OrderByDescending(p => p.Name)

                });
            var trainers = pocemonsByTrainer
                  .Select(p => new Trainer
                  {
                      Name = p.trName,
                      Pokemons = p.poc.ToList(),
                  }).ToList();

            string command = Console.ReadLine().Trim();
            while (command != "End")
            {
                foreach (var tr in trainers)
                {
                    if (tr.Pokemons.Any(p => p.Element == command) && tr.Pokemons.Any(p => p.Health >0))
                    {
                        tr.Badges++;
                    }
                    else
                    {
                        foreach (var pocemon in tr.Pokemons)
                        {
                            pocemon.Health -= 10;
                        }
                    }
                }
                command = Console.ReadLine().Trim();
            }
            trainers.
                OrderByDescending(tr => tr.Badges).
                ToList().
                ForEach(tr => Console.WriteLine($"{tr.Name} {tr.Badges} {tr.Pokemons.Count(poc => poc.Health >0)}"));
        }
    }
}
