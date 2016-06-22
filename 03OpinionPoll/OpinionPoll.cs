using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OpinionPoll
{
   public class OpinionPoll
    {
        public static void Main()
        {
            int numOfRows = int.Parse(Console.ReadLine());
            List<Person> allPersons = new List<Person>();

            for (int row = 0; row < numOfRows; row++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person
                {
                    name = input[0],
                    age = int.Parse(input[1])
                };

                allPersons.Add(person);
            }

            Console.WriteLine(string.Join("\n", allPersons.Where(x => x.age>30)
                .OrderBy(x => x.name)
                .Select (x => $"{x.name} - {x.age}")));
        }
    }
}
