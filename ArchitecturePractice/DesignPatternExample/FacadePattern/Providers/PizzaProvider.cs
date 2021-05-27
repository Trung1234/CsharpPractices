using FacadePattern.Providers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Providers
{
    /// <summary>
    /// pizza provider class which will get pizza for their clients
    /// </summary>
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }
        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }

        /// <summary>
        /// client is not bothered about Getting Non Veg Pizza Toppings
        /// </summary>
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
    }
}
