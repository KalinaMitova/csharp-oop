using System;
using System.Collections.Generic;
using System.Text;

namespace _10FamilyTree
{
   public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Parent> Parents { get; }
        public List<Child> Children { get; }

        public Person (string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public Person(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public Person(string name,DateTime dateOfBirth)
            :this(name)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public void AddChild (Child child)
        {
            bool allreadyExist = false;

            foreach (var ch in this.Children)
            {
                if (ch.Name == child.Name && string.IsNullOrEmpty(ch.Name))
                {
                    ch.DateOfBirth = child.DateOfBirth;
                    allreadyExist = true; 
                    break;
                }

                else if (ch.DateOfBirth == child.DateOfBirth && ch.DateOfBirth != DateTime.MinValue)
                {
                    ch.Name = child.Name;
                    allreadyExist = true;
                    break;
                }
            }

            if (!allreadyExist)
            {
                Children.Add(child);
            }
        }

        public void AddParent(Parent parent)
        {
            bool allreadyExist = false;
            for (int i = 0; i < this.Parents.Count; i++)
            {
                if (this.Parents[i].Name == parent.Name && !string.IsNullOrEmpty(this.Parents[i].Name))
                {
                    this.Parents[i].DateOfBirth = parent.DateOfBirth;
                    allreadyExist = true;
                    break;
                }

                else if (this.Parents[i].DateOfBirth == parent.DateOfBirth && this.Parents[i].DateOfBirth != DateTime.MinValue)
                {
                    this.Parents[i].Name = parent.Name;
                    allreadyExist = true;
                    break;
                }
            }

             if (!allreadyExist)
                {
                Parents.Add(parent);
            }
        }

        public override string ToString()
        {
            StringBuilder printPerson = new StringBuilder();
            printPerson.AppendLine($"{this.Name} {this.DateOfBirth.Day}/{this.DateOfBirth.Month}/{DateOfBirth.Year}");
            printPerson.AppendLine($"Parents:");
            if (this.Parents.Count > 0)
            {
                printPerson.AppendLine(string.Join("\n", this.Parents));
            }
            printPerson.AppendLine($"Children:");
            if (this.Children.Count > 0)
            {
                printPerson.Append(string.Join("\n", this.Children));
            }

            return printPerson.ToString(); 
        }
    }
}
