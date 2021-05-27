using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Steak và Pizza chính là các Concrete Command.
    /// </summary>
    public class Pizza : IOrder
    {
        private PizzaChef chef;

        public Pizza()
        {
            this.chef = new PizzaChef();
        }
        public void Execute()
        {
            chef.MakePizza();
        }

        public override string ToString()
        {
            return nameof(Pizza);
        }
    }
}
