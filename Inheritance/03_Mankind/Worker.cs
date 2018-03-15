using System;
using System.Text;

//•	If the workers last name’s length is less than 3 symbols, print: 
//" Expected length at least 3 symbols! Argument: lastName"
//•	Week salary should be more than 10, if it doesn’t, print: 
//"Expected value mismatch! Argument: weekSalary"
//•	Working hours should be in the range[1, 12], if they are not, print:
//"Expected value mismatch! Argument: workHoursPerDay"

namespace _03_Mankind
{
   internal class Worker : Human
    {
        private const int WorkingDaysInWeek = 5;
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weeklySalary, decimal workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weeklySalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        protected override string LastName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($" Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }
        }

        private decimal WeekSalary
        {
            get { return this.weekSalary; }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        private decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            decimal salaryPerHour = this.WeekSalary / (WorkingDaysInWeek * this.WorkHoursPerDay);
            return salaryPerHour;
        }

        public override string ToString()
        {
            StringBuilder printWorker = new StringBuilder();
            printWorker.AppendLine($"First Name: {base.FirstName}");
            printWorker.AppendLine($"Last Name: {base.LastName}");
            printWorker.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            printWorker.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            printWorker.AppendLine($"Salary per hour: {GetSalaryPerHour():f2}");

            return printWorker.ToString();
        }
    }
}
