using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class Degree
    {
        public string Name { get; set; }
        public List<Course> Courses;

        public Degree(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
