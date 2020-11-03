using Day2InClass.Models;
using Day2InClass.Services;
using System;

namespace Day2InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.GetValidStudentNumber();
            stud1.GetValidName();
            stud1.ShowStudentDetails();
            
            Printer.PromptValidation();

            if (Console.ReadLine() != "Y")
            {
                stud1.GetValidStudentNumber();
                stud1.GetValidName();
                stud1.ShowStudentDetails();
            }
            Printer.PrintConfirmation();
            Console.Read();
        }
    }
}
