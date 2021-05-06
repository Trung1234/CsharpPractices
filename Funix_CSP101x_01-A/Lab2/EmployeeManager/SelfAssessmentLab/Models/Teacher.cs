using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessmentLab.Models
{
    public class Teacher : Person
    {
        private static int count = 1;

        public Teacher(string name, string subjectName) : base(name, subjectName)
        {
            this.ID = count++;
        }
        public void GradeTest()
        {
            Console.WriteLine("Teacher " + Name + " grades " + SubjectName + " Test");
        }
    }
}
