using FacadePattern.Facade;
using System;

namespace FacadePattern
{
    /// <summary>
    /// Facade is a structural design pattern 
    /// that provides a simplified interface to a library, a framework, or any other complex set of classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // the client is using the restaurant façade class to order pizza and bread of different types 
            // without directly interacting with the subclasses.
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            Console.ReadKey();
        }
    }
}
