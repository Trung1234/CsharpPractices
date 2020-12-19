using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    /// <summary>
    /// Waiter sẽ là cầu nối giữa Customer và Chef: Invoker.
    /// </summary>
    public class Waiter
    {
        public void TakeOrder(IOrder order)
        {
            Console.WriteLine("Waiter take new order " + order.ToString());
            order.Execute();
        }
    }
}
