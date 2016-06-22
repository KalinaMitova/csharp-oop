using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Define a class Employee that holds the following information: name, salary, position, department, email and age.The name, 
// salary, position and department are mandatory while the rest are optional.
//Your task is to write a program which takes N lines of employees from the console and calculates the department with the 
//highest average salary and prints for each employee in that department his name, salary, email and age – sorted by salary in
//descending order. If an employee doesn’t have an email – in place of that field you should print “n/a” instead, if he
//doesn’t have an age – print “-1” instead.The salary should be printed to two decimal places after the seperator.
namespace _04CompanyRoster
{
   public class Employee
    {
        public Employee()
        {
        }

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
       private string name;
       private decimal salary;
       private string position;
       private string department;
       private string email;
       private int age;

    }
}
