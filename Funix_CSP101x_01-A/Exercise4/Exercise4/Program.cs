using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // MakeDecisions();
            // MakeIfAndElseWorkTogether();
            // RepeatOperations();
            // WorkWithForLoop();
            // CreatedNestedLoops();
            CombineBranchesAndLoops();
            Console.ReadLine();
        }

        /// <summary>
        /// Combine branches and loops
        /// Find the sum of all integers 1 through 20 that are divisible by 3. 
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=6
        /// </summary>
        static void CombineBranchesAndLoops()
        {
            int sum = 0;
            for (int number = 1; number <= 20; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum of all integers 1 through 20 that are divisible by 3: {sum}");
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=5
        /// </summary>
        static void CreatedNestedLoops()
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
        /// <summary>
        /// Work with the for loop
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=4
        /// </summary>
        static void WorkWithForLoop()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }

            for (int counter = 2; counter < 20; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
        }

        /// <summary>
        /// Use loops to repeat operations
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=3
        /// </summary>
        static void RepeatOperations()
        {
            // The while loop tests the condition before executing the code following the while.
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            // The do ... while loop executes the code first, and then checks the condition. I
            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        /// <summary>
        /// Make if and else work together
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=2
        /// </summary>
        static void MakeIfAndElseWorkTogether()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            //You can also use || to represent "or":
 
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        /// <summary>
        /// Make decisions using the if statement
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=1
        /// </summary>
        static void MakeDecisions()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
 
            //Modify the declaration of b so that the sum is less than 10:
            b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

        }
    }
}
