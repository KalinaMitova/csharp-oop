using System;

//Define class TriangularPrism that has base side, height from base side and length. Define class Cube that has side length and class Cylinder
//that has radius and height. Define class VolumeCalculator that holds static methods for calculating the volume of these three figures. The 
//input will be read from the console until command “End” is received and will be in some of these formats: 
//•	TriangularPrism <base side> <height> <length>
//•	Cube <side length>
//•	Cylinder <radius> <height>
//The volume in the output must be rounded 3 digits after the floating point.

namespace _08_Shapes_Volume
{
    public class TriangularPrism
    {
        private double baseSide;
        private double baseHeight;
        private double height;

        public double BaseSide => this.baseSide;
        public double BaseHeight => this.baseHeight;
        public double Height => this.height;

        public TriangularPrism(double baseSide, double baseHeight, double height)
        {
            this.baseSide = baseSide;
            this.baseHeight = baseHeight;
            this.height = height;
        }

    }

    public class Cube
    {
        private double side;

        public double Side => this.side;

        public Cube(double side)
        {
            this.side = side;
        }

    }

    public class Cylinder
    {
        private double radius;
        private double height;

        public double Radius => this.radius;
        public double Height => this.height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
    }
    public class VolumeCalculator
    {
        public static double CalculateVolumeTriangularPrism (TriangularPrism prism)
        {
            return (prism.BaseSide * prism.BaseHeight / 2d) * prism.Height;
        }

        public static double CalculateVolumeCube(Cube cube)
        {
            return cube.Side * cube.Side * cube.Side;
        }

        public static double CalculateVolumeCylinderm(Cylinder cylinder)
        {
            return cylinder.Radius * cylinder.Radius * Math.PI * cylinder.Height;
        }
    }
   public  class ShapesVolume
    {
       public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                double result = 0;
                switch (input[0])
                {
                    case "TrianglePrism": result = VolumeCalculator.CalculateVolumeTriangularPrism(new TriangularPrism( double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]))); break;
                    case "Cube": result = VolumeCalculator.CalculateVolumeCube(new Cube(double.Parse(input[1]))); break;
                    case "Cylinder": result = VolumeCalculator.CalculateVolumeCylinderm(new Cylinder(double.Parse(input[1]), double.Parse(input[2]))); break; 
                }

                Console.WriteLine("{0:F3}", result);
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
