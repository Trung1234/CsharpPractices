using System;
using System.Collections.Generic;
using System.Text;
using TutorialLab2.Models.Base;

namespace TutorialLab2.Models
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmployee(string name) : base(name, 50000)
        {
        }

        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
