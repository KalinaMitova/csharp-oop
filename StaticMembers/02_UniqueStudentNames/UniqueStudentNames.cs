using System;
using System.Collections.Generic;
using System.Linq;

//Define class Student containing a single field – name.Now Define class StudentGroup with HashSet<Student> field that will keep all unique students.
//You are going to receive user input containing student’s names as single parameter on the line until you receive command “End”. Create new 
//instances of Students class and keep track of all unique names using static counter within the StudentGroup class. Then print the count of unique 
//names.

namespace _02_UniqueStudentNames
{
    public class Student
    {
        private string name;

        public string Name => this.name;

        public Student(string name)
        {
            this.name = name;
        }
    }

    public class StudentGruop
    {
        static HashSet<Student> uniqueStudents;

        static  StudentGruop()
        {
            uniqueStudents = new HashSet<Student>();
        }

        public static void Add(Student student)
        {
            bool isUnique = true;
            foreach (var st  in uniqueStudents)
            {
                if (st.Name == student.Name)
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                uniqueStudents.Add(student);
            }
        }

        public static int CountUniqueStudents()
        {
            return uniqueStudents.Count();
        }

    }

    class UniqueStudentNames
    {
        static void Main(string[] args)
        {
            string studentInput = Console.ReadLine().Trim();

            while (studentInput != "End")
            {
                Student student= new Student(studentInput);
                StudentGruop.Add(student);
                studentInput = Console.ReadLine().Trim();
            }
            Console.WriteLine(StudentGruop.CountUniqueStudents());
        }
    }
}
