using Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            Customer customer = new Customer(waiter);
            customer.Request("pizza");
            customer.Request("steak");
            Console.ReadLine();
        }
    }
}
