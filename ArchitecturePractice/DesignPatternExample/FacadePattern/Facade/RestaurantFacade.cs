using FacadePattern.Providers;
using FacadePattern.Providers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Facade
{
    /// <summary>
    /// Facade pattern hides the complexities of the systems 
    /// and provides a simple interface to the clients.
    /// </summary>
    public class RestaurantFacade
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;

        /// <summary>
        /// restaurant façade class, which will be used by the client to order different pizzas or breads.
        /// </summary>
        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }
        public void GetNonVegPizza()
        {
            _PizzaProvider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _PizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBread();
        }
    }
}
