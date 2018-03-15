using System;
using System.Numerics;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create class Calculation. Define static constant with value 6.62606896e-34 (Planck constant) and 3.14159 (Pi). Add static method that returns 
//reduced Planck constant by the formula: 
//{Planck constant} / (2 * {Pi constant})
//Print the result of the method on a single line on the console.Do not format in any way the result.

namespace _06_PlanckConstant
{
   
    public class Calculation
    {
        private static double planckConstant ;
        private static double pi;

        static Calculation()
        {
            planckConstant = 6.62606896d;
            pi = 3.14159d;
        }

        private static double ReducePlanckConstant()
        {
            return planckConstant / (2 * pi);
        }

        public static string PrintResult()
        {
            return $"{ReducePlanckConstant()}E-34";
        }

    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Calculation.PrintResult());
        }
    }
}
