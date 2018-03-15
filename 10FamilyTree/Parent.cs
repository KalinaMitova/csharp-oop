using System;

namespace _10FamilyTree
{
   public class Parent
    {

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Parent(string name)
        {
            this.Name = name;
        }

        public Parent(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public Parent(string name,DateTime dateOfBirth)
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
