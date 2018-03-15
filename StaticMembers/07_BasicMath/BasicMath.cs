using System;

//Define MathUtil class that supports basic mathematical operations:
//•	Sum <first number> <second number>
//•	Subtract<first number> <second number>
//•	Multiply<first number> <second number>
//•	Divide<dividend> <divisor>
//•	Percentage<total number> <percent of that number>
//Use static methods and make sure that the application will work with floating point numbers.
//Read from the console until you receive command “End”. Results must be formatted with 2 digits after the floating point.

namespace _07_BasicMath
{
    public class MathUtil
    {
        public static double Sum (double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        public static double Percentage(double totalNumber, double percentOfThatNumber)
        {
            return (totalNumber/ 100)*percentOfThatNumber;
        }

    }
    public class BasicMath
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                double result = 0;
                switch (input[0])
                {
                    case "Sum": result = MathUtil.Sum(double.Parse(input[1]), double.Parse(input[2])); break;
                    case "Subtract": result = MathUtil.Subtract(double.Parse(input[1]), double.Parse(input[2])); break;
                    case "Multiply": result = MathUtil.Multiply(double.Parse(input[1]), double.Parse(input[2])); break;
                    case "Divide": result = MathUtil.Divide(double.Parse(input[1]), double.Parse(input[2])); break;
                    case "Percentage": result = MathUtil.Percentage(double.Parse(input[1]), double.Parse(input[2])); break;
                }

                Console.WriteLine("{0:F2}", result);
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
