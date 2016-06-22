using System;
using System.Collections.Generic;
using System.Linq;
   //Define a class Employee that holds the following information: name, salary, position, department, email and age.The name, 
   // salary, position and department are mandatory while the rest are optional.
   //Your task is to write a program which takes N lines of employees from the console and calculates the department with the 
   //highest average salary and prints for each employee in that department his name, salary, email and age – sorted by salary in
   //descending order. If an employee doesn’t have an email – in place of that field you should print “n/a” instead, if he
   //doesn’t have an age – print “-1” instead.The salary should be printed to two decimal places after the seperator.

namespace _04CompanyRoster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {
            int numOfInputRows = int.Parse(Console.ReadLine());
            List<Employee> emplyees = new List<Employee>();

            for (int i = 0; i < numOfInputRows; i++)
            {
                string[] inputEmployee = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Employee employee = new Employee(inputEmployee[0],
                    decimal.Parse(inputEmployee[1]),
                    inputEmployee[2],
                    inputEmployee[3]);

                if (inputEmployee.Length > 4)
                {
                    if (inputEmployee[4].Contains("@"))
                    {
                        employee.Email = inputEmployee[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(inputEmployee[4]);
                    }
                }
                if (inputEmployee.Length > 5)
                {
                    employee.Age = int.Parse(inputEmployee[5]);
                }

                emplyees.Add(employee);
             }

            //decision with LINQ

            var result = emplyees.GroupBy(e => e.Department).
                 Select(e => new
                 {
                     Department = e.Key,
                     AvaregeSalary = e.Average(emp => emp.Salary),
                     Employees = e.OrderByDescending(em => em.Salary)
                 })
                 .OrderByDescending(e => e.AvaregeSalary)
                 .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var emp in result.Employees)
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}"); 
            }
            //var empl = emplyees.GroupBy(x => x.Department).ToList();
            //decimal avarageSalary = 0m;
            //string departmentHighestAverageSalary = null;
            //foreach (var group in empl)
            //{
            //    decimal sumSalary = 0;
            //    int countSalary = 0;
            //    foreach (var data in group)
            //    {
            //        sumSalary += data.Salary;
            //        countSalary++;
            //    }

            //    decimal avarageSalaryGroup = sumSalary / countSalary;
            //    if (avarageSalaryGroup >= avarageSalary)
            //    {
            //        departmentHighestAverageSalary = group.Key;
            //        avarageSalary = avarageSalaryGroup;
            //    }
            //}

            //Console.WriteLine($"Highest Average Salary: {departmentHighestAverageSalary}");

            //foreach (var group in empl)
            //{
            //    if (group.Key == departmentHighestAverageSalary)
            //    {
            //        foreach (var data in group.OrderByDescending(x => x.Salary))
            //        {
            //            Console.WriteLine($"{data.Name} {data.Salary:F2} {data.Email} {data.Age}");
            //        }
            //    }
            //}


        }
    }
}
