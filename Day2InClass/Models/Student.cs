using System;
using System.Collections.Generic;
using System.Text;

namespace Day2InClass.Models
{
    class Student
    {
        public string Name { get; set; }
        public string StudentNumber { get; set; }

        public Student(string StudentNumber, string Name)
        {
            this.StudentNumber = StudentNumber;
            this.Name = Name;
        }
    }
}
