using FactoryPattern.Common;
using FactoryPattern.Factory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            carFactory.CreateFactory(Constants.CarEnum.Hyundai);
            Console.ReadLine();
        }
    }
}
