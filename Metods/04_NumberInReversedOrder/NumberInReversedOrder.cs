using System;

namespace _04_NumberInReversedOrder
{
    public class DecimalNumber
    {
        private string number;

        public string NUmber => this.number;

        public DecimalNumber (string number)
        {
            this.number = number;
        }

        public void PrintReversNumber()
        {
            char[] numberArray = this.number.ToCharArray();
            Array.Reverse(numberArray);
            Console.WriteLine(string.Join("",numberArray));
        }
    }

    public class NumberInReversedOrder
    {
        public static void Main()
        {
            DecimalNumber number = new DecimalNumber(Console.ReadLine());

            number.PrintReversNumber();
        }
    }
}
