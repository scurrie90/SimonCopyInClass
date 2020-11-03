using System;

namespace Day2InClass
{
    class Student
    {
        public string Name { get; private set; }
        public string StudentNumber { get; private set; }

        public Student(string StudentNumber, string Name)
        {
            this.StudentNumber = StudentNumber;
            this.Name = Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a student number.");
            string id = Console.ReadLine();
            
            Console.WriteLine("Provide a student name.");
            string name = Console.ReadLine();
            
            // create an instance of the Student Class
             Student stud1 = new Student(id, name);

            Console.WriteLine("Student 1 is: " + stud1.StudentNumber + " " + stud1.Name);
            Console.Read();
        }
    }
}
