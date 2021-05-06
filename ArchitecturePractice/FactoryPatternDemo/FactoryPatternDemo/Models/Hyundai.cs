using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public class Hyundai : ICar
    {
        public void ShowDetail()
        {
            Console.WriteLine("Show Hyundai's Infor");
        }
    }
}
