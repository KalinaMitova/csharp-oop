using System;
using System.Collections.Generic;
using System.Linq;

//Create class Person with fields name and age.Create a class Family. The class should have list of people, method 
//for adding members(void AddMember(Person member)) and a method returning the oldest family member(Person 
//GetOldestMember()). Write a program that reads name and age for N people and add them to the family.Then 
//print the name and age of the oldest member.
//namespace _02._OldestFamilyMember

namespace _02._OldestFamilyMember
{ 
    public class Person
    {
        private string name;
        private int age;

        public string Name => this.name;
        public int Age => this.age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} {age}";
        }
    }

    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }

        public Person GetOldestMember()
        {
            return persons.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }

   public  class OldestFamilyMember
    {
        public static void Main()
        {

            int numOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < numOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }

            Console.WriteLine(family.GetOldestMember());
        }

    }
}
