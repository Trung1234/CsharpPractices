using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunTutorialLab1();
            //RunTutorialLab2();
            //RunTutorialLab3();
            //RunTutorialLab4();
            RunSelfAssessmentLab();
            Console.ReadLine();
        }

        /// <summary>
        /// Self Assessment Lab
        /// https://courses.edx.org/courses/course-v1:Microsoft+DEV204.1x+3T2019/courseware/76a698ba76c748299a9bd6798a67d7c7/8bf324bde5e54bff9c7cb70d4d80c436/?activate_block_id=block-v1:Microsoft+DEV204.1x+3T2019+type@sequential+block@8bf324bde5e54bff9c7cb70d4d80c436
        /// </summary>
        static void RunSelfAssessmentLab()
        {
            Console.WriteLine("Create the appropriate nested looping structure to output the characters in an 8 x 8 grid");
            for (int x = 1; x <= 8; x++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    if (x % 2 == 0)
                    {
                        if (y % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else
                    {
                        if (y % 2 == 0)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                    if (y == 8)
                        Console.WriteLine();
                }
               
            }
        }


        /// <summary>
        /// Tutorial Lab 4 for Module 2 - Using while and do Loops
        /// https://courses.edx.org/courses/course-v1:Microsoft+DEV204.1x+3T2019/courseware/76a698ba76c748299a9bd6798a67d7c7/8bf324bde5e54bff9c7cb70d4d80c436/?activate_block_id=block-v1:Microsoft+DEV204.1x+3T2019+type@sequential+block@8bf324bde5e54bff9c7cb70d4d80c436
        /// </summary>
        static void RunTutorialLab4()
        {
            // Create a while loop
            // We start with n = 1
            // The condition check for the while, tests if n is less than 6, if so, the loop body code executes
            // inside the loop, we output the value of n and then increment it by 1
            // Once n = 6, the loop stops
            // Pay attention to the output to see what the last value is to ensure you understand
            // how the evaluation of the condition is done and how the while loop executes
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }
            // Create a do loop, also known as a do..while loop
            // Note that with the do loop, the loop will run at least once regardless of the value of x
            // which is due to the condition not being checked until the end.
            // Experiment with this by setting x to a value greater than 5 and run the code
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);
        }

        /// <summary>
        /// Tutorial Lab 3 for Module 2 - Using a for Loop
        /// https://courses.edx.org/courses/course-v1:Microsoft+DEV204.1x+3T2019/courseware/76a698ba76c748299a9bd6798a67d7c7/8bf324bde5e54bff9c7cb70d4d80c436/?activate_block_id=block-v1:Microsoft+DEV204.1x+3T2019+type@sequential+block@8bf324bde5e54bff9c7cb70d4d80c436
        /// </summary>
        static void RunTutorialLab3()
        {
            // Create a simple for loop that displays the values of the counter
            // The WriteLine method here demonstrates the use of string interpolation in C#
            // as a way of outputting literal string values with variable values.
            // It is the recommended way to deal with this method of string output
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Counter is at: {counter}");
            }
            // Create a nested for loop
            // This sample uses a nested loop to find prime numbers
            // less than 100

            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break; // if factor found, not prime
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);
            }
        }

        /// <summary>
        /// Tutorial Lab 2 for Module 2 - Using a switch Statement
        /// https://courses.edx.org/courses/course-v1:Microsoft+DEV204.1x+3T2019/courseware/76a698ba76c748299a9bd6798a67d7c7/8bf324bde5e54bff9c7cb70d4d80c436/?activate_block_id=block-v1:Microsoft+DEV204.1x+3T2019+type@sequential+block@8bf324bde5e54bff9c7cb70d4d80c436
        /// </summary>
        static void RunTutorialLab2()
        {
            // Create a switch block
            Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }
        /// <summary>
        /// Tutorial Lab 1 for Module 2 - Using an if Statement
        /// https://courses.edx.org/courses/course-v1:Microsoft+DEV204.1x+3T2019/courseware/76a698ba76c748299a9bd6798a67d7c7/8bf324bde5e54bff9c7cb70d4d80c436/?activate_block_id=block-v1:Microsoft+DEV204.1x+3T2019+type@sequential+block@8bf324bde5e54bff9c7cb70d4d80c436
        /// </summary>
        static void RunTutorialLab1()
        {
            // Request user input with ReadLine()
            Console.WriteLine("Please enter an integer value and press Enter.");
            // Assign the entered value to the variable input
            // convert input to integer before using
            int input = Int32.Parse(Console.ReadLine());
            // Check to see if the number is even.
            // Here we use the simple task of checking for a remainder when dividing by 2
            // The (%) or modulus operator returns the remainder of integer devision.
            // If the remainder is 0, then the value is able to be divided by 2 with
            // no remainder, which means it is an even number.
            if (input % 2 == 0)
            {
                Console.WriteLine("The entered number was an even number.");
            }
            else  // the remainder was not 0 so the value entere is an odd number.
            {
                Console.WriteLine("The entered number was not an even number.");
            };
        }
    }
}
