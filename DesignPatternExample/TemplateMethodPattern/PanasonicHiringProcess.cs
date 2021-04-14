using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class PanasonicHiringProcess : HiringProcessTemplate
    {
        public override void InterviewFirstRound()
        {
            Console.WriteLine("Conduct Direct Interview With HR In English" + Environment.NewLine);
        }

        public override void InterviewTechnicalRound()
        {
            Console.WriteLine("Conduct Interview With Principal Engineer In 1 Hours" + Environment.NewLine);
        }
    }
}
