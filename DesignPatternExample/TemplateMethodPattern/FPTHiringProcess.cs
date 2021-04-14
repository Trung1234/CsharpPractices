using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class FPTHiringProcess : HiringProcessTemplate
    {
        public override void InterviewFirstRound()
        {
            Console.WriteLine("Conduct Remote Interview With HR In Japaness" + Environment.NewLine);
        }

        public override void InterviewTechnicalRound()
        {
            Console.WriteLine("Conduct Remote Interview With Delivery Manager In 30 Minutes" + Environment.NewLine);
        }
    }
}
