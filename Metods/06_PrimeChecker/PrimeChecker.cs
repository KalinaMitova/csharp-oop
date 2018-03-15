using System;

namespace _06_PrimeChecker
{
    public class Number
    {
        private int num;
        private bool isPrime;

        public int Num => this.num;

        public bool PrimOrNot(int num)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        public Number GetNextPrim(Number number)
        {
            int num = number.num +1;
            while (true)
            {
                bool prime = PrimOrNot(num);
                if (prime == true)
                {
                    break;
                }
                num++;
            }
            number = new Number(num, number.isPrime);
            return number;
        }

        public Number(int num)
        {
            this.num = num;
            this.isPrime = PrimOrNot(num);
        }

        private Number(int num, bool isPrime)
            :this(num)
        {
            this.num = num;
            this.isPrime = isPrime;
        }

        public override string ToString()
        {
            return $"{this.num}, {this.isPrime.ToString().ToLower()}";
        }
    }
    public class PrimeChecker
    {
        static void Main()
        {
            Number number = new Number(int.Parse(Console.ReadLine()));
            number = number.GetNextPrim(number);

            Console.WriteLine(number);
        }
    }
}
