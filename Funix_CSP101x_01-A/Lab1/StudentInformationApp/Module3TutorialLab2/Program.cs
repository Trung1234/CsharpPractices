using System;

namespace Module3TutorialLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");
            Console.ReadLine();
        }

        /// <summary>
        /// Method Divide() that contains exception handling to deal with 
        /// divide by zero exceptions.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

            return result;
        }
    }
}
