using Day2InClass.Models;
using System;

namespace Day2InClass
{
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
            Console.WriteLine("New Student: Number = " + stud1.StudentNumber + " Name = " + stud1.Name);
            Console.WriteLine("Are the above values correct? Y/N ");
            string correct = Console.ReadLine();

            if (correct != "Y")
            {
                Console.WriteLine("Provide a student number.");
                id = Console.ReadLine();

                Console.WriteLine("Provide a student name.");
                name = Console.ReadLine();

                stud1.StudentNumber = id;
                stud1.Name = name;
                Console.WriteLine("New Student: Number = " + stud1.StudentNumber + " Name = " + stud1.Name);
            }
            Console.WriteLine("Thanks, student has been created");
            Console.Read();
        }
    }
}
