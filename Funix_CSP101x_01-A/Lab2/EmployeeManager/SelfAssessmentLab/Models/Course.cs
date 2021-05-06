using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessmentLab.Models
{
    public class Course
    {
        public string Name { get; set; }
        public IList<Student> Students { get; set; }
        public IList<Teacher> Teachers { get; set; }
    }
}
