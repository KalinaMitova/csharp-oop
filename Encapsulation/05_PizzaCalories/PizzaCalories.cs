using System;

namespace _05_PizzaCalories
{
    public class PizzaCalories
    {
        public static void Main()
        {

            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "Pizza")
            {
                try
                {
                    Pizza pizza = new Pizza(input[1], int.Parse(input[2]));
                    while (input[0] != "END")
                    {
                        ReturnResultFromPizza(input,pizza);
                        
                        input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    }
                    Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                
            }
            else
            {
                while (input[0] != "END")
                {
                    ReturnResultFromToppingsAndDough(input);
                    input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            

        }

        public static void ReturnResultFromToppingsAndDough(string[] input)
        {
            switch (input[0])
            {
                case "Dough":
                    try
                    {

                        Dough dough = new Dough(input[1], input[2], double.Parse(input[3]));
                        Console.WriteLine($"{dough.GetCaloriesOfDough():F2}");

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "Topping":
                    try
                    {

                        Topping topping = new Topping(input[1], double.Parse(input[2]));
                        Console.WriteLine($"{topping.GetCaloriesOfTopping():F2}");

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }

        public static void ReturnResultFromPizza(string[] input, Pizza pizza)
        {
            switch (input[0])
            {
                case "Dough":
                        Dough dough = new Dough(input[1], input[2], double.Parse(input[3]));
                        pizza.DoughPizza = dough;
                    break;
                case "Topping":
                        Topping topping = new Topping(input[1], double.Parse(input[2]));
                        pizza.AddTooping(topping);
                    break;
            }
        }
    }
}
