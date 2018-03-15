using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three
//parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: 
//http://www.mathwords.com/r/rectangular_parallelepiped.htm).
//On the first three lines you will get the length, width and height.On the next three lines print the surface area, lateral surface area and 
//the volume of the box:

namespace _01_ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double CalculateSurfaceArea ()
        {
            return 2 * (this.length * this.width) + 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double CalculateVolume()
        {
            return this.length * this.width * this.height; 
        }
    }

    public class ClassBox
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine().Trim());
            double width = double.Parse(Console.ReadLine().Trim());
            double height = double.Parse(Console.ReadLine().Trim());

            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}{Environment.NewLine}Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}{Environment.NewLine}Volume - {box.CalculateVolume():F}");
        }
    }
}
