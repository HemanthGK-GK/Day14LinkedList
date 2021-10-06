using System;
using System.Collections.Generic;
using System.Text;

namespace UC3Linkedlist
{
    class List
    {
        internal Node head;
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        internal void Add(int data)
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
            Console.WriteLine(node.data+" inserted into the Linked List");
        }

        internal void Append(int Ndata)
        {
            Node new_node = new Node(Ndata);
            if (head == null)
            {
                head = new Node(Ndata);
                return;
            }
            new_node.next = null;
            Node last = head;
            while (last.next != null)
                last = last.next;
            last.next = new_node;
            Console.WriteLine(Ndata + " append to previous node");
            return;
        }
    }
    }

