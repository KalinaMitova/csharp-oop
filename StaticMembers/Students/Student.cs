using System;

//Define class Student. Add string field for a student’s name that you are going to receive as a console input. Then add a static Integer field to keep track of 
//how many students’ instances are created. Initialize the static field with 0 (zero) and increment in the constructor. When you receive command “End” stop reading
//more students names and print their total count on the console.

namespace Students
{
    public class Person
    {
        static int instanceCounter;

       public  static int PersonCounter
        {
            get
            {
                return Person.instanceCounter;
            }
        }

        private string name;

        public Person(string name)
        {
            Person.instanceCounter++;
            this.name = name;
        }
    }
    class Student
    {
        static void Main()
        {
            string personInput = Console.ReadLine().Trim();

            while (personInput != "End")
            {
                Person person = new Person (personInput);
                personInput = Console.ReadLine().Trim();
            }
            Console.WriteLine(Person.PersonCounter);
        }
    }
}
