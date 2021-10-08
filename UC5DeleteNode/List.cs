using System;
using System.Collections.Generic;
using System.Text;

namespace UC5DeleteNode
{
    class List
    {
         Node head;
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

        public Node RemoveFirst()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next; 
            }
        }
    }
}
