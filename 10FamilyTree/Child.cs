using System;

namespace _10FamilyTree
{
   public class Child
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Child(string name)
        {
            this.Name = name;
        }

        public Child(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public Child(string name, DateTime dateOfBirth)
            :this(name)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.DateOfBirth.Day}/{this.DateOfBirth.Month}/{this.DateOfBirth.Year}";
        }
    }
}
