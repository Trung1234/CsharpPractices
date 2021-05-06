using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string addressLine1 = "";
            string addressLine2 = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Assign some values for Student
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            addressLine1 = "123 Fourth Street";
            addressLine2 = "723 Fourth Street";
            city = "Anytown";
            country = "England";
            birthDate = new DateTime(1932, 6, 1);

            // output to the console window Student Information
            Console.WriteLine("----------------Student Information--------------");
            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine("{0} years old.", age);

            // use string concatenation
            Console.WriteLine(addressLine1 + ", " +addressLine2 + ", " + city + ", " + country);

            // use string interpolation
            Console.WriteLine($"Born on {birthDate}");

            // Assign some values for Teacher
            firstName = "Henry";
            lastName = "Thumb";
            age = 38;
            addressLine1 = "23 Fourth Street";
            addressLine2 = "73 Fourth Street";
            city = "Anytown";
            country = "England";
            birthDate = new DateTime(1962, 6, 1);

            // output to the console window Student Information
            Console.WriteLine("----------------Teacher Information----------");
            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine("{0} years old.", age);

            // use string concatenation
            Console.WriteLine(addressLine1 + ", " + addressLine2 + ", " + city + ", " + country);

            // use string interpolation
            Console.WriteLine($"Born on {birthDate}");

            // create variables of different data types
            // initialize with a "default" value
            string programName = "UProgram ";
            string departmentHead = "New York";
            string degrees = "Advanced";
            // output to the console window UProgram
            Console.WriteLine("----------------UProgram----------");
            Console.WriteLine("Program Name: {0}, Department Head: {1}, Degrees: {2}", programName, departmentHead, degrees);

            // create variables of different data types
            // initialize with a "default" value
            string degreeName = "Economy";
            bool creditsRequired = true;
            // output to the console window Degree Information
            Console.WriteLine("----------------Degree Information----------");
            Console.WriteLine($"Degree Name : { degreeName }");
            if (creditsRequired)
                Console.WriteLine("credits is required");
            else
                Console.WriteLine("credits is not required");

            // create variables of different data types
            // initialize with a "default" value
            string courseName = "Math";
            string credits = "Revolving";
            int durationInWeeks = 4;
            string teacher = "Gate";
            // output to the console window Course Information
            Console.WriteLine("----------------Course Information----------");
            Console.WriteLine($"Course Name: { courseName },Credits : { credits },	Duration in Weeks : { durationInWeeks } Day a week,Teacher  Name : { teacher  }");

            Console.ReadLine();
        }
    }
}
