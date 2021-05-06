using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/list-collection?tutorial-step=5
            // CreateLists();
            // Challenge
            // with Fibonacci Numbers. Try and write the code to generate the first 20 numbers in the sequence. 
            List<int> fibonacciNumbers = new List<int>();
            fibonacciNumbers.Add(1);
            fibonacciNumbers.Add(1);
            while(fibonacciNumbers.Count < 20)
            {
                //f(n) = f(n-1) + f(n-2)
                int fibonacciNumber = fibonacciNumbers[fibonacciNumbers.Count - 2] + fibonacciNumbers[fibonacciNumbers.Count - 1];
                fibonacciNumbers.Add(fibonacciNumber);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
            Console.ReadLine();
        }

        static void CreateLists()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            //Lists of other types
            var fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
