using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


//Create two classes: class Person and class Product. Each person should have a name, money and a bag of products. Each product should have name 
//and cost. Name cannot be an empty string. Money cannot be a negative number. 
//Create a program in which each command corresponds to a person buying a product.If the person can afford a product add it to his bag.If a person 
//doesn’t have enough money, print an appropriate message.
//On the first two lines you are given all people and all products.After all purchases print every person in the order of appearance and all 
//products that he has bought also in order of appearance.If nothing is bought, print the name of the person followed by "Nothing bought". 
//In case of invalid input (negative money or empty name) break the program with an appropriate exception message.

namespace _04_ShoppingSpree
{
    public class ShoppingSpree
    {
       public static void Main()
        {
            string personData = Console.ReadLine();
            string productData = Console.ReadLine();

            List<Person> persons = new List<Person>();  // ;Може да се направи дикшънъри от стринг и пърсънт
            List<Product> products  = new List<Product>();

            string[] persData = personData.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            string[] prodsData = productData.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < persData.Length; i++)
                {
                    string name = null;
                    decimal money = 0;
                    string[] nameMoney = persData[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    if (nameMoney.Length == 1)
                    {
                        name = null;
                        money = decimal.Parse(nameMoney[0]);
                    }
                    else
                    {
                        name = nameMoney[0];
                        money = decimal.Parse(nameMoney[1]);
                    }

                    Person person = new Person(name, money);
                    persons.Add(person);
                }

                for (int i = 0; i < prodsData.Length; i++)
                {
                    string name = null;
                    decimal cost = 0;
                    string[] nameCost = prodsData[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    if (nameCost.Length == 1)
                    {
                        name = null;
                        cost = decimal.Parse(nameCost[0]);
                    }
                    else
                    {
                        name = nameCost[0];
                        cost = decimal.Parse(nameCost[1]);
                    }

                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                string input = Console.ReadLine();

                while (input != "END")
                {
                    string[] command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var per in persons)
                    {
                        if (per.Name == command[0])
                        {
                            foreach (var prod in products)
                            {
                                if (command[1] == prod.Name)
                                {
                                    Console.WriteLine(per.AddProductToBag(prod)); ;
                                    break;
                                }
                            }
                        }
                    }
                    input = Console.ReadLine();
                }

                foreach (var per in persons)
                {
                    if (per.BagOgProducts.Count == 0)
                    {
                        Console.WriteLine($"{per.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{per.Name} - {string.Join(", ", per.BagOgProducts)}");
                    }
                }

            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return; // излизаме от метода, спира програмата когато сме в майн метода
            }


            //string pattern = @"\b((?:[A-za-z]+)?)\s*=\s*(-?\d+)\b";       

            //Regex personProduct = new Regex(pattern);

            //MatchCollection personMatches = personProduct.Matches(personData);

            //try
            //{ 
            //foreach (Match per in personMatches)
            //{      
            //        Person person = new Person(per.Groups[1].Value, decimal.Parse(per.Groups[2].Value));
            //        persons.Add(person);              
            //}

            //MatchCollection productMatches = personProduct.Matches(productData);

            //foreach (Match prod in productMatches)
            //{

            //        Product product = new Product(prod.Groups[1].Value, decimal.Parse(prod.Groups[2].Value));
            //        products.Add(product);

            //}
           
        }
    }
}
