using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The observer pattern is a software design pattern in which an object, 
            //named the subject, maintains a list of its dependents, called observers, 
            //and notifies them automatically of any state changes, usually by calling one of their methods.
            // Create a girl instance as subject (publisher)
            var sexyGirl = new HotGirl();

            //// Add 2 boys to her friend zone.
            sexyGirl.AddToZone(new Boy("Alex"));
            sexyGirl.AddToZone(new Boy("Bob"));

            // One day. She need some attention, so she post to facebook.
            // After she complete post facebook. These poor boys react.
            sexyGirl.PostFacebook();
            Console.ReadKey();
        }
    }
}
