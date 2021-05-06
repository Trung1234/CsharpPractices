using System;
using System.Collections.Generic;
using System.Text;
using TutorialLab2.Models.Base;

namespace TutorialLab2.Models
{
    class TechnicalEmployee : Employee
    {
        // Creates integer variable called "successfulCheckIns" and assigns value to 5
        public int successfulCheckIns = 5;

        // We want to reuse the constructor that we created in the Employee() Clas
        // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
        // Sets baseSalary to 75000 for all TechnicalEmployee objects
        // This "imports" our Employee() Class constructor and allows us to use that constructor as we instantiate a new TechnicalEmployee object.
        public TechnicalEmployee(string name) : base(name, 75000)
        {
        }

        // This method returns the toString() method - which is the employee's ID number and name 
        // - and prints the number of successful check ins the employee has had 
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
