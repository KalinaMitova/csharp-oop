using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Mankind
{
    internal class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected virtual string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                }
                this.firstName = value;
            }
        }

        protected virtual string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                }
                this.lastName = value;
            }
        }
    }
}
