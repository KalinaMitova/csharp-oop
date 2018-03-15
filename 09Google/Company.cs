namespace _09Google
{
   public class Company
    {
        private string mainName;
        private string companyName;
        private string department;
        private double salary;

        public string MainName => this.mainName;

        public Company(string mainName, string companyName, string department, double salary)
        {
            this.mainName = mainName;
            this.companyName = companyName;
            this.department = department;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{companyName} {department} { salary:F2}";
        }
    }
}
