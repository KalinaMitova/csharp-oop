using System;

namespace _06_PrimeChecker
{
    public class Numbers
    {
        private int num;
        private bool isPrime;

        public int Num => this.num;

        public bool PrimOrNot (int num)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num%i == 0 )
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        public int GetNextPrim (int num, bool isPrime)
        {
            num ++;
            while (true)
            {
                isPrime = PrimOrNot(num);
                if (isPrime == true)
                {
                    break;
                }
                num++;
            }

            return num;
        }

        public Numbers(int num)
        {
            this.num = num;
            this.isPrime = PrimOrNot(num);
        }

        public override string ToString()
        {
            return $"{GetNextPrim(this.num, this.isPrime)}, {this.isPrime.ToString().ToLower()}";
        }
    }
}
