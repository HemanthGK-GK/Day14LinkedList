using System;
using System.Collections.Generic;
using System.Text;

namespace UC8InsertAtPosition
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

        public void InsertAfter(Node prev_node, int data)
        {
            Node new_node = new Node(data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;

        }

        public bool Search( int x)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == x)
                    return true;
                temp = temp.next;
            }
            return false; 
        }

    }
}
