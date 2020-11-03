using System;
using System.Collections.Generic;
using System.Text;

namespace Day2InClass.Services
{
    static class Printer
    {
        static public void PromptStudentNumber()
        {
            Console.WriteLine("Please provide a student number.");
        }
        static public void PromptStudentName()
        {
            Console.WriteLine("Provide a student name.");
        }
        static public void PromptValidation()
        {
            Console.WriteLine("Are the above values correct? Y/N ");
        }

        static public void PrintConfirmation()
        {
            Console.WriteLine("Thanks, student has been created");
        }
    }
}
