using System;

namespace _03_Mankind
{
  public  class Mankind
    {
      public  static void Main()
        {
            string[] inputStudent = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstNameOfStudent = inputStudent[0];
            string lastNameOfStudent = inputStudent[1];
            string facultyNumber = inputStudent[2];

            string[] inputWorker = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstNameOfWorker = inputWorker[0];
            string lastNameOfWorker = inputWorker[1];
            decimal salary = decimal.Parse(inputWorker[2]);
            decimal workingHours = decimal.Parse(inputWorker[3]);

            try
            {
                Student student = new Student(firstNameOfStudent, lastNameOfStudent, facultyNumber);
                Worker worker = new Worker(firstNameOfWorker, lastNameOfWorker, salary, workingHours);
                Console.WriteLine(student);
                Console.WriteLine(worker);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
