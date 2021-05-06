using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessmentLab.Models
{
    public class UProgram
    {
        public string Name { get; set; }
        public IList<Degree> Degrees { get; set; }
    }
}
