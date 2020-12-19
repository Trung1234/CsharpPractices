using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    /// <summary>
    /// Steak Chef và Pizza Chef đóng vai trò Receiver.
    /// </summary>
    public class PizzaChef
    {
        public void MakePizza()
        {
            Console.WriteLine("I'm making pizza");
        }
    }
}
