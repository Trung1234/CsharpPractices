using DIContainerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainerApp.Models
{
    public class Audi : ICar
    {
        private int _mile = 0;
        public int Run()
        {
            return ++_mile;
        }
    }
}
