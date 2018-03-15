using System;
using System.Linq;
using System.Reflection;

namespace _02_ClassBoxDataValidation
{
   public class ClassBoxDataValidation
    {
       public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine().Trim());
            double width = double.Parse(Console.ReadLine().Trim());
            double height = double.Parse(Console.ReadLine().Trim());
            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}{Environment.NewLine}Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}{Environment.NewLine}Volume - {box.CalculateVolume():F}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
