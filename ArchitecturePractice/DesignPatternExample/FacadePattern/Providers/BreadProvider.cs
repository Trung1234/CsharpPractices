using FacadePattern.Providers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Providers
{
    /// <summary>
    /// Bread provider class which will get Bread for their clients
    /// </summary>
    public class BreadProvider : IBread
    {
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }

        /// <summary>
        ///  client is not bothered about Getting Cheese
        /// </summary>
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}
