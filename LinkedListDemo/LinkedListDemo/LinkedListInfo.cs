using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    //LinkedList Is A Linear Data Strucutre.
    //It consists a groups of nodes in a sequence.
    //First DATA- each node of a linked list can store a data.
    //Second Addresss - each node of a linked list contains the address of the next node , "next".
    internal class LinkedListInfo
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(head == null )
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while( temp.next != null )
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null )
            {
                Console.WriteLine("Linked List Is Empty");
            }
            while( temp != null )
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
