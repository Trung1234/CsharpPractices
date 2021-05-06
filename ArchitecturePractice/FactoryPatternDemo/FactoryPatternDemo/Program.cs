using FactoryPatternDemo.Common;
using FactoryPatternDemo.Factory;
using System;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            carFactory.ViewCar(Constants.CarEnum.Hyundai);
            Console.ReadLine();
        }
    }
}
