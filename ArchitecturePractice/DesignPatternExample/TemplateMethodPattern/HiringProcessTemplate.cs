using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// template of the hiring process for all kinds of company
    /// </summary>
    public abstract class HiringProcessTemplate
    {
        public void HireNewEmployee()
        {
            InterviewFirstRound();
            InterviewTechnicalRound();
            DiscussInGroup();
        }   
        public abstract void InterviewFirstRound();
        public abstract void InterviewTechnicalRound();
        protected void DiscussInGroup()
        {
            Console.WriteLine("Conduct Group Discussion Interview " + Environment.NewLine);
        }
    }
}
