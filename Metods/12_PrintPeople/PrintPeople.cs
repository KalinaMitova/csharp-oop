using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Person. Every person should have name, age and occupation. Your task is to create the class and read some people, while adding 
//them to a collection. Sort them by age and print them in the given format. Override the ToString() and CompareTo() methods.

namespace _12_PrintPeople
{
    public class Person
    {
        private string name;
        private int age;
        private string occupation;

        public int Age => this.age;

        public Person (string name, int age, string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        public override string ToString()
        {
            return $"{name} - age: {age}, occupation: {occupation}";
        }

    }
    public class PrintPeople
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();

            while (input[0] != "END")
            {
                Person person = new Person(input[0], int.Parse(input[1]), input[2]);

                persons.Add(person);

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var result = persons.OrderBy(x => x.Age);

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
