using System;

//Create a program that converts temperature from Celsius to Fahrenheit and vice versa.Use static methods.The input data will be in format:
//{temperature} {unit}. Temperatures will be in integer number and units will be one of these two values: Celsius / Fahrenheit.Output value
//must be double value following of empty space and the converted unit.You are going to receive input, until you receive command “End”. The 
//output must be formatted 2 digits after floating point.

namespace _03_TemperatureConverter
{
    public class Temperature
    {
        private double value;
        private string unit;

        public double Value
        {
            get { return value; }
            set { this.value = value;}
        }

        public string Unit
        {
            get { return unit; }
            set { this.unit = value; }
        }

        public Temperature()
        {
        }

        public Temperature(double value, string unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public string PrintTemperature()
        {
            return $"{value:F2} {unit}";
        }
    }
    public class ConvertTemperature
    { 
        public static Temperature ConvertTemperatures(Temperature temp)
        {
            Temperature convertedTem = new Temperature();
            if (temp.Unit == "Celsius")
            {
                convertedTem.Unit = "Fahrenheit";
                convertedTem.Value = temp.Value * 1.8 + 32;
            }
            else if (temp.Unit == "Fahrenheit")
            {
                convertedTem.Unit = "Celsius";
                convertedTem.Value = (temp.Value - 32)/1.8;
            }
            return convertedTem;
        }
    }
    public class TemperatureConverter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                Temperature temp = new Temperature(double.Parse(input[0]), input[1]);
                temp = ConvertTemperature.ConvertTemperatures(temp);
                Console.WriteLine(temp.PrintTemperature());
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
