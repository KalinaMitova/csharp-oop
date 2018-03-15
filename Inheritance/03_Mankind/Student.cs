using System;

namespace _03_Mankind
{
    internal class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        protected override string FirstName           
        {
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }
                base.FirstName = value;
            }  
        }

        protected override string LastName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }
        }

        private string FacultyNumber
        {
           set
            {
                if ((value.Length >10 || value.Length < 5)
                    || IsInvalidFacultyNumber(value))
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        private bool IsInvalidFacultyNumber (string facultyNumber)
        {
            bool isInvalid = false;
            foreach (var letter in facultyNumber)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    isInvalid = true;
                    break;
                }
            }

            return isInvalid;
        }

        public override string ToString()
        {
            return $"First Name: {base.FirstName}{Environment.NewLine}Last Name: {base.LastName}{Environment.NewLine}Faculty number: {this.facultyNumber}{Environment.NewLine}";
        }
    }
}
