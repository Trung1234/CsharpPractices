using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class LinkedList<T>
    {
        /// <summary>
        /// ref to first link on list
        /// </summary>
        private Link<T> first;

        public LinkedList()
        {
            this.first = null; // no links on list yet
        }

        public void AddFirst(int id, T data)
        {
            var newLink = new Link<T>
            {
                Index = id,
                Data = data
            };
            newLink.Next = first;//it point to old first link
            first = newLink; // now first points to this
        }

        public Link<T> Find(int key)
        {
            var current = first;//start at beginning of the list
            while(current.Index != key)
            {
                //find till the end of list
                if (current.Next == null)
                    return null; // did not find it
                else
                    current = current.Next;//go to next link
            }
            return current;//found
        }

        public void DisplayList()
        {
            Console.WriteLine("List (first --> Last)!");
            Link<T> current = first;
            while(current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;//go to next link
            }
            Console.WriteLine(" ");
        }
    }
}
