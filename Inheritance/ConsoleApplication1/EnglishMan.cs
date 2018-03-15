using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        private string name;
        private int age;
        private decimal salary;
        private string departament;
        public string Departament
        {
           get { return this.name; }
            set { this.departament = value; }
        }

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Nme => this.name;
        public string GetName()
        {
            return this.name;
        }

        public decimal GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(decimal salary)
        {
            if (salary<0)
            {

            }
            this.salary = salary;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
           private set
            {
                if (value.Length <3 || value == null)
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value >120)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.age = value;
            }
        }

       
    }
}
