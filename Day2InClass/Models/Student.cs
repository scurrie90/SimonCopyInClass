using Day2InClass.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2InClass.Models
{
    class Student
    {
        public string Name { get; set; }
        public string StudentNumber { get; set; }

        public Student() { }

        public Student(string StudentNumber, string Name)
        {
            this.StudentNumber = StudentNumber;
            this.Name = Name;
        }

        public void GetValidName()
        {
            Printer.PromptStudentName();
            // add any validation logic
            this.Name = Console.ReadLine();
        }

        public void GetValidStudentNumber()
        {
            Printer.PromptStudentNumber();
            // add any validation logic
            this.StudentNumber = Console.ReadLine();
        }

        public void ShowStudentDetails()
        {
            Console.WriteLine("New Student: Number = " + this.StudentNumber + " Name = " + this.Name);
        }
    }
}
