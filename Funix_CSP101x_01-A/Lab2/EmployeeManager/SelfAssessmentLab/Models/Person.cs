using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessmentLab.Models
{
    public abstract class Person
    {
        private string name;
        private int id;
        private string subjectName;

        // Public properties

        public string SubjectName
        {
            get
            {
                return subjectName;
            }

            set
            {
                subjectName = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        // Constructor
        public Person(string name, string subjectName)
        {           
            this.Name = name;
            this.SubjectName = subjectName;
        }


        // This method returns the employee's name
        public String getName()
        {
            return this.Name;
        }
        // This method returns the employee's ID and Name
        public String toString()
        {
            return "ID: "+this.ID + " Name: " + this.Name;
        }
    }
}
