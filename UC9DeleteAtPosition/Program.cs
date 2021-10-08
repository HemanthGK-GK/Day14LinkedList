using System;

namespace UC9DeleteAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();

            if (list.Search(40) == true)
            {
                list.DeleteNode(40);
                Console.WriteLine("\n--------------------");
                list.Display();
            }
            else
                Console.WriteLine("Value Not Found in list");
        }

    }
}
