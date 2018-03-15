using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Animals
{
   public class Animal
    {
        private  Sound sound;
        private string name;
        private double age;
        private string gender;

        public Animal(string name, double age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        protected double Age
        {
            get { return this.age; }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        protected virtual string Gender
        {
            get { return this.gender; }

            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        protected Sound SoundType
        {
            get { return this.sound; }
            set { this.sound = value; }
        }

        public override string ToString()
        {
            StringBuilder printAnimal = new StringBuilder();
            printAnimal.AppendLine($"{GetType().Name}");
            printAnimal.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            printAnimal.Append($"{SoundType.ProduceSound()}");

            return printAnimal.ToString();
        }

    }
}
