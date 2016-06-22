using System;
using System.Reflection;


namespace _01DefineClassPerson
{
   public class DefineClassPerson
    {
       public static void Main()
        {
            //    Type personType = typeof(Person);
            //    FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //    Console.WriteLine(fields.Length);

            //Person firstPerson = new Person
            //{
            //    name = "Pesho",
            //    age = 20
            //};

            //Person secondPerson = new Person();
            //secondPerson.name = "Gosho";
            //secondPerson.age = 18;

            //Person thirdPerson = new Person
            //{
            //    name = "Stamat",
            //    age = 43
            //};

            Type personType = typeof(Person);
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

        }
    }
}
