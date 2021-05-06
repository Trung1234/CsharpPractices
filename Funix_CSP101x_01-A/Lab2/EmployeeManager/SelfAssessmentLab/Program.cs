using SelfAssessmentLab.Models;
using System;
using System.Collections.Generic;

namespace SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> students = new List<Student>()
            {
                new Student("Libby", "English" ),
                new Student("Alex", "English" )
            };
            Teacher teacher1 = new Teacher("Bob", "English" );
            Course programming = new Course {
                Name = "Programing",
                Students = students,
                Teachers = new List<Teacher> { teacher1 }
            };
            Degree bachelor = new Degree
            {
                Name = "Bachelor",
                Courses = new List<Course> { programming }
            };
            UProgram informationTechnology = new UProgram
            {
                Name = "Information Technology",
                Degrees = new List<Degree> { bachelor}
            };
            Console.WriteLine("The name of the program : {0}", informationTechnology.Name);
            Console.WriteLine("The name of the degree : {0}", bachelor.Name);
            Console.WriteLine("The name of the course in the degree : {0}", programming.Name);
            Console.WriteLine("Teacher's Information : {0}", teacher1.toString());
            teacher1.GradeTest();
            Console.WriteLine("Student's Information :");
            foreach(var student in students)
            {
                Console.WriteLine(student.toString());
                student.TakeTest();
            }

            Console.WriteLine("The number of students : {0}", students.Count);
            Console.ReadLine();
        }
    }
}
