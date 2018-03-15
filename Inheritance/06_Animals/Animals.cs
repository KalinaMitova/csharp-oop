using System;

namespace _06_Animals
{
   public class Animals
    {
       public static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            try
            {
                while (input != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               
                    string name = animalData[0];
                    double age = double.Parse(animalData[1]);
                    

                    switch (input.ToLower())
                    {
                        case "cat":
                            string gender = animalData[2];
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            break;

                        case "dog":
                            gender = animalData[2];
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            break;
                        case "frog":
                            gender = animalData[2];
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            break;
                        case "kitten":
                            Kitten kitten = new Kitten(name, age);
                            Console.WriteLine(kitten);
                            break;
                        case "tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            Console.WriteLine(tomcat);
                            break;
                    }
               

                input = Console.ReadLine().Trim();
            }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
