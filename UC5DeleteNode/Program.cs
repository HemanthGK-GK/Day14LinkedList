using System;

namespace UC5DeleteNode
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.RemoveFirst();
            Console.WriteLine("\n------------");
            list.Display();
        }
    }
}
