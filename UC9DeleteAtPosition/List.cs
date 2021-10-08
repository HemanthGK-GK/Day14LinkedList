using System;
using System.Collections.Generic;
using System.Text;

namespace UC9DeleteAtPosition
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
        public bool Search(int x)
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

        internal void DeleteNode(int data)
        {
            
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == data)
            {  
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
           
            if (temp == null)
                return;
            
            prev.next = temp.next;
        }
    }
}
