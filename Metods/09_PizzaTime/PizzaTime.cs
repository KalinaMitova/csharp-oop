using System;
using System.Collections.Generic;
using System.Linq;

//Create a class Pizza. Every Pizza has a name (e.g. “Peperoni”) and a group. You should make it have a functionality to return its name and group.
//Write a method(in the class Pizza), which parameters are Strings and the result is a SortedDictionary of groups(integer) as key and list of names
//(strings) as value.On the single input line, you will receive some strings.Every string is in format {group number}{pizza name}
//Your task is to get the input from the console and create a collection of pizza instances.Set their names and their groups to correspond the input.
//Make a SortedDictonary consisting of the group and all pizza names of that group. After you collect the input, print the groups and their pizzas. 
//You must use params!

namespace _09_PizzaTime
{
    public class Pizza
    {
        public string name;
        public int groupNumber;

        public Pizza (int groupNumber, string name)
        {
            this.name = name;
            this.groupNumber = groupNumber;
        }

        public static SortedDictionary<int, List<string>> SortedPizzaByGroup(params Pizza[] pizzaList)
        {
            SortedDictionary<int, List<string>> sortedPizza = new SortedDictionary<int, List<string>>();

            foreach (var piza in pizzaList)
            {
                if (!sortedPizza.ContainsKey(piza.groupNumber))
                {
                    sortedPizza.Add(piza.groupNumber, new List<string>());
                }
                sortedPizza[piza.groupNumber].Add(piza.name);
            }

            return sortedPizza;
        }
    }

    public class PizzaTime
    {
        public static void Main()
        {
            System.Reflection.MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            string[] inputPizza = Console.ReadLine().Split(new[] {' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<Pizza> pizzaList = new List<Pizza>();

            //Regex pizzaMatch = new Regex(@"\b(\d)+([A-za-z]+)\b");
            //MatchCollection allPizza = pizzaMatch.Matches(inputPizza);
            //foreach (Match match in allPizza)
            //{
            //    Pizza pizza = new Pizza(match.Groups[2].Value, match.Groups[1].Value);
            //    pizzaList.Add(pizza);

            //}
            foreach (var str in inputPizza)
            {
                int indexOfFirstLetter = -1;
                for (int i =0; i<str.Length; i++)
                {
                    if (char.IsLetter(str[i]))
                    {
                        indexOfFirstLetter = i;
                        break;
                    }
                }
                if (indexOfFirstLetter != -1)
                {
                    int groupNum = int.Parse(str.Remove(indexOfFirstLetter));
                    string pizzaName = str.Substring(indexOfFirstLetter);
                    Pizza pizza = new Pizza(groupNum,pizzaName);
                    pizzaList.Add(pizza);
                }
                
            }

            var result = Pizza.SortedPizzaByGroup(pizzaList.ToArray());

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
