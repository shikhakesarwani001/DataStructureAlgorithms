using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
public class LinkedList
    {
      Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int value)
            {
                data = value;
                next = null;
            }
        }
        public void pintList()
        {
            Node n = head;
            while (n.next != null)
            {
                Console.Write(n.data);
                n = n.next;

            }
        }

        public void reveseLinkedList()
        {

            Node current=head;
            Node next_node=null;
            Node prev_node=null;

            while(current!=null){
                next_node=current.next;
                current.next=prev_node;
                prev_node=current;
                current=next_node;
            }
            head=prev_node;

        }
    }



}

