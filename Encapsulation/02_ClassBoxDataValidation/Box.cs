using System;
using System.CodeDom.Compiler;

namespace _02_ClassBoxDataValidation
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");    
                }
                this.height = value;
            }
        }


        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * (this.Length * this.Width) + 2 * this.Length * this.Height + 2 * this.Width * this.Length;
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double CalculateVolume()
        {
            return this.Length * this.Width * this.Height;
        }

    }
}
