using System;
using System.Collections.Generic;

namespace UC1LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(56);
            linkedList.AddFirst(30);
            linkedList.AddFirst(70);
            

            foreach (int i in linkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
