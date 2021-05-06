using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessmentLab.Models
{
    public class Degree
    {
        public string Name { get; set; }
        public IList<Course> Courses;
    }
}
