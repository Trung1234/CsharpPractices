using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    /// <summary>
    /// Hot Girl is Observable (Subject)
    /// </summary>
    public class HotGirl
    {
        private bool needAttention = false;

        /// <summary>
        /// State of instance. When state change, observe will  know and react.
        /// </summary>
        private bool NeedAttention
        {
            get => needAttention;
            set
            {
                needAttention = value;
                Notify();
            }
        }

        /// <summary>
        /// Some of boys crushing this instance 
        /// </summary>
        public IList<Boy> FriendZone = new List<Boy>();

        public void PostFacebook()
        {
            Console.WriteLine("Complete post");
            NeedAttention = true;
        }
        
        public void Notify()
        {
            foreach (var b in FriendZone)
            {
                b.Care();
            }
        }

        /// <summary>
        /// Register observer. 
        /// </summary>
        /// <param name="b"></param>
        public void AddToZone(Boy b)
        {
            FriendZone.Add(b);
        }     
    }
}
