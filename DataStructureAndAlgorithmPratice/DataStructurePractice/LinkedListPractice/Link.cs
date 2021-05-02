using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class Link<T>
    {
        /// <summary>
        /// key
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// data item
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// next link in list
        /// </summary>
        public Link<T> Next { get; set; }

        /// <summary>
        /// display
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return "Index: "+Index+" Data: "+Data;
        }
    }
}
