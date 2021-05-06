using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialLab1.Models
{
    // BusinessEmployee Class inheriting from Employee Class
    public class BusinessEmployee : Employee
    {
        // Creates double variable called "bonusBudget" and assigns value to 1000
        public double bonusBudget = 1000;

        // Calls upon base-class (Employee Class) constructor from within derived class (BusinessEmployee Class)
        // Sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(string name) : base(name, 50000)
        {
        }

        // This method returns the toString() method - which is the employee's ID number and name - and prints the bonus budget
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
