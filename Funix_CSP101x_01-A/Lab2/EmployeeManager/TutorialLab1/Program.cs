using System;
using TutorialLab1.Models;

namespace TutorialLab1
{
    class Program
    {
        //https://courses.edx.org/courses/course-v1:Microsoft+DEV204.2x+3T2019/courseware/e4a9fc9fd68f48458f99c0ebb5f89817/710a8d5dc4c94a3198defdbb61a52197/?activate_block_id=block-v1%3AMicrosoft%2BDEV204.2x%2B3T2019%2Btype%40sequential%2Bblock%40710a8d5dc4c94a3198defdbb61a52197
        static void Main(string[] args)
        {
            // Instantiates Employee Object with name Libby and salary 2000 called employee1
            var employee1 = new Employee("Libby", 2000);
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee2 = new TechnicalEmployee("Zaynah");
            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee3 = new BusinessEmployee("Winter");

            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
            Console.ReadLine();
        }
    }
}
