using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public class Mercedes : ICar
    {
        public void ShowDetail()
        {
            Console.WriteLine("Show Mercedes's Infor");
        }
    }
}
