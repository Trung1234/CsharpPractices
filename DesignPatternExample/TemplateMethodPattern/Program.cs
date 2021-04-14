using System;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------FPT Recruitment-------");
            HiringProcessTemplate hiringProcess = new FPTHiringProcess();
            hiringProcess.HireNewEmployee();
            Task.Delay(1000);
            Console.WriteLine("-------Panasonic Recruitment-------");
            hiringProcess = new PanasonicHiringProcess();
            hiringProcess.HireNewEmployee();
        }
    }
}
