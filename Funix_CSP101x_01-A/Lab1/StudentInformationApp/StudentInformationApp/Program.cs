using System;

namespace StudentInformationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetStudentInformation();
                GetTeacherInformation();
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();
            DateTime birthdayDateTime = DateTime.Now;
            if (!DateTime.TryParse(birthday,out birthdayDateTime))
            {
                throw new NotImplementedException();
            }
            PrintStudentDetails(firstName, lastName, birthday);         
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday");
            string birthday = Console.ReadLine();
            DateTime birthdayDateTime = DateTime.Now;
            if (!DateTime.TryParse(birthday, out birthdayDateTime))
            {
                throw new NotImplementedException();
            }
            Console.WriteLine("Enter the teacher's address");
            string address = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, birthday, address);
        }

        static void PrintTeacherDetails(string first, string last, string birthday,string address)
        {
            Console.WriteLine("{0} {1} was born on: {2} and live at {3}", first, last, birthday, address);
        }
    }
}
