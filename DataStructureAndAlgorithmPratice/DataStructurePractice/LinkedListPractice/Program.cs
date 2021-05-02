using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<double> linkedList = new LinkedList<double>();
            linkedList.AddFirst(21, 3.2);
            linkedList.AddFirst(11, 6.2);
            linkedList.AddFirst(24, 7.2);
            linkedList.AddFirst(25, 8.2);
            linkedList.AddFirst(26, 9.2);
            var searchedLink = linkedList.Find(11);
            if(searchedLink == null)
                Console.WriteLine("Cannot find with key = 11");
            else
                Console.WriteLine("find with key = 11 and value = "+searchedLink.Data);
            linkedList.DisplayList();
            Console.ReadLine();
        }
    }
}
