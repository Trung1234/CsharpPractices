using FactoryPattern.Common;
using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factory
{
    public class CarFactory
    {
        public void CreateFactory(Constants.CarEnum carName)
        {
            ICar car;
            if (carName.Equals(Constants.CarEnum.Hyundai))
            {
                car = new Hyundai();
                car.ShowDetail();
            }
            else if (carName.Equals(Constants.CarEnum.Lamborghini))
            {
                car = new Lamborghini();
                car.ShowDetail();
            }
            else if (carName.Equals(Constants.CarEnum.Mercedes))
            {
                car = new Mercedes();
                car.ShowDetail();
            }
            else
            {
                Console.WriteLine("This type of car is not exist");
            }
        }
    }
}
