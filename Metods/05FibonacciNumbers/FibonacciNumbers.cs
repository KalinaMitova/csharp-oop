using System;
using System.Collections.Generic;

//Define a class Fibonacci. It should keep a list of all Fibonacci numbers starting from 0, 1 until Nth number in the sequence.
//Write a method in the Fibonacci class that receives as parameters start position and end position and returns part of the 
//sequence starting from start position(inclusive) until end position(exclusive). 
//List<int> GetNumbersInRange(int startPosition, int endPosition).
//Write a program that reads start position and end position and prints the Fibonacci numbers in that range.

namespace _05FibonacciNumbers
{
    public class Fibonacci
    {
        private List<long> nums;

        public Fibonacci(int numLast)
        {
            nums = new List<long> { 0, 1 };
            for (int i = 2; i < numLast; i++)
            {
                long num = nums[i - 2] + nums[i - 1];
                nums.Add(num);
            }
        }

        public List<long> GetNumbersInRange(int startPosition, int endPosition)
        {
            return this.nums.GetRange(startPosition, endPosition - startPosition); ;
        }

    }
   public class FibonacciNumbers
    {
        public static void Main()
        {
            int startPosition = int.Parse(Console.ReadLine());
            int endPosition = int.Parse(Console.ReadLine());

            Fibonacci fibonacciSequence = new Fibonacci(endPosition);

            Console.WriteLine(string.Join(", ", fibonacciSequence.GetNumbersInRange(startPosition, endPosition)));
        }
    }
}
