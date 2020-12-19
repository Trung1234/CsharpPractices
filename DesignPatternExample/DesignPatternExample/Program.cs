using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
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
