using DIContainerApp.Interfaces;
using DIContainerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DIContainerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();// Map Icar wwith BMW
            //Resolves dependencies and returns the Driver object 
            Driver drv = container.Resolve<Driver>();
            drv.RunCar();
            Console.ReadLine();
        }
    }
}
