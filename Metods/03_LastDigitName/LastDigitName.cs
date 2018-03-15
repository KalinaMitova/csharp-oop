using System;

namespace _03_LastDigitName
{
    public class Number
    {
        private int num;

        public int Num => this.num;

        public Number(int number)
        {
            this.num = number;
        }

        public string PrintLastDigitName()
        {
            string[] digitName = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            int digit = this.num % 10;

            return $"{digitName[digit]}";        }
    }

    public class LastDigitName
    {
       public static void Main()
        {
  
            Number number = new Number(int.Parse(Console.ReadLine()));

            Console.WriteLine(number.PrintLastDigitName());
        }
    }
}
