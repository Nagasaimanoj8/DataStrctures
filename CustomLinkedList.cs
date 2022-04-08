using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class CustomLinkedList
    {
        public Node head;


        public void AddAtLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;

            }
            else
            {
                Node lastnode = GetLastNode();
                lastnode.next = newNode;

            }
        }
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }


            }
        }
    }
}