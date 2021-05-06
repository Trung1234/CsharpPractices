using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessmentLab.Models
{
    public class Student : Person
    {
        private static int count = 1;
        public Student(string name, string subjectName) : base(name, subjectName)
        {
            this.ID = count++;
        }

        public void TakeTest()
        {
            Console.WriteLine("Student "+Name+" takes "+SubjectName+" Test");
        }
    }
}
