using System;
using System.Collections.Generic;
using System.Text;

namespace UC7SearchKey
{
    class List
    {
       internal Node head;
        public class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " inserted into the Linked List");
        }

        internal void Search(int x)
        {
            int flag = 0;
            Node temp = head; 
            while (temp != null)
            {
                if (temp.data == x)
                    flag = 1;  
               
                break;
                temp = temp.next;
            }

            if(flag==1)
                Console.WriteLine(x + "is present in the list");
            else
            Console.WriteLine(x + "is not present in the list");
        }
    }
}
