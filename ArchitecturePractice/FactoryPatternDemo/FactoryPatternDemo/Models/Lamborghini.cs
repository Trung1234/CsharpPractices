using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public class Lamborghini : ICar
    {
        public void ShowDetail()
        {
            Console.WriteLine("Show Lamborghini's Infor");
        }
    }
}
