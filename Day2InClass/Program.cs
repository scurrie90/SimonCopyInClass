using System;

namespace Day2InClass
{
    class Student
    {
        public string Name { get; private set; }
        public string StudentNumber { get; private set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of the Student Class
            Student stud1 = new Student(); 
            Console.WriteLine(stud1.StudentNumber + " " + stud1.Name);
            Console.Read();
        }
    }
}
