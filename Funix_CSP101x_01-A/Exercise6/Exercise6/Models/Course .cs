using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class Course
    {
        public string Name { get; set; }
        public List<Student> Students;
        public List<Teacher> Teachers;
        public Course(string name)
        {
            Name = name;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddTeacher(Teacher taacher)
        {
            Teachers.Add(taacher);
        }
    }
}
