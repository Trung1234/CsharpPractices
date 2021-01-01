using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    /// <summary>
    /// Boy is Observer
    /// </summary>
    public class Boy
    {
        public string Name { get; set; }

        public Boy(string name)
        {
            Name = name;
        }

        public void Care()
        {
            Console.WriteLine($"{Name}: Are you OK?");
        }
    }

}
