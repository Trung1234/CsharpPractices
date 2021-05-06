using FactoryPatternDemo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo.Factory
{
    public class CarFactory
    {
        public void ViewCar(Constants.CarEnum carName)
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
