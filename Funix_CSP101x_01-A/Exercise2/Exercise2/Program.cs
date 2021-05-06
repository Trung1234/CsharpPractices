using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExploreIntegerMath();
            //ExploreOrderOfOperations();
            //ExploreIntegerPrecisionAndLimits();
            //WorkWithDoubleType();
            //WorkWithDecimalType();
            CompleteChallenge();
            Console.ReadLine();
        }

        /// <summary>
        /// Challenge
        /// write code that calculates the area of a circle whose radius is 2.50 centimeters. 
        /// </summary>
        static void CompleteChallenge()
        {
            //  Remember that the area of a circle is the radius squared multiplied by PI. 
            double radius = 2.5;
            double area = radius * radius * Math.PI;
            Console.WriteLine($"The area of a circle : {area}");
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp?tutorial-step=5
        /// </summary>
        static void WorkWithDecimalType()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);          
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp?tutorial-step=1
        /// </summary>
        static void ExploreIntegerMath()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp?tutorial-step=2
        /// </summary>
        static void ExploreOrderOfOperations()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            Console.WriteLine(d);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp?tutorial-step=3
        /// </summary>
        static void ExploreIntegerPrecisionAndLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp?tutorial-step=4
        /// </summary>
        static void WorkWithDoubleType()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            a = 19;
            b = 23;
            c = 8;
            d = (a + b) / c;
            Console.WriteLine(d);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            // Challenge
            // Try other calculations with large numbers, small numbers, multiplication, and division using the double type. 
            double result1 = 3.125 / 4.0;
            Console.WriteLine(result1);
            double result2 = 2048*6.25;
            Console.WriteLine(result2);
        }
    }
}
