using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    /// <summary>
    /// Steak và Pizza chính là các Concrete Command.
    /// </summary>
    public class Steak : IOrder
    {
        private SteakChef chef;

        public Steak()
        {
            this.chef = new SteakChef();
        }
        public void Execute()
        {
            chef.makeSteak();
        }

        public override string ToString()
        {
            return nameof(Steak);
        }
    }
}
