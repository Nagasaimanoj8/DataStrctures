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
            Console.WriteLine("{0} Node inserted into linkedlist", newNode.data);
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
        public void AddAtFirst(int new_data)
        {
            // creating a node
            Node new_node = new Node(new_data);
            // when we want to add the node at front
            new_node.next = this.head;
            //the previous Head node is no=w the second node of linked list
            this.head = new_node;
            Console.WriteLine("{0} Node inserted into linkedlist", new_node.data);
        }
        public void Append(int data)
        {
            AddAtLast(data);
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range {position}");
            }
            Console.WriteLine("\nInserted Value is  ", head);
            return head;

        }
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list empty");
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("\n{0} is deleted from the list", deleteNode);
            return deleteNode;
        }
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List empty");
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lastDeleteNode = newNode.next.data;
            newNode.next = null;
            return lastDeleteNode;
        }
        public int Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    //Console.WriteLine("\nNode is present");
                    return value;
                }
                temp = temp.next;
            }
            Console.WriteLine("\n{0} is not present", value);
            return 0;

        }
        public void InsertAfterValue(int after, int data)
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("Successfull added Element {after} After {data}");
            }
        }
        public void DeleteElement(int data)
        {
            bool flag = false;
            int count = 0;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }
                        previousNode.next = temp.next;
                        flag = true;
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                }
                if (!flag)
                {
                    Console.WriteLine($"\n{data} Successfully Delete Element");
                }
                else
                {
                    Console.WriteLine($"\nElement Not Found in linked list {data}");
                }
            }
        }
        public int Count()
        {
            int count = 0;
            Node temp = head;
            while(temp != null)
            {
                temp=temp.next;
                count++;
            }
            Console.WriteLine($"\nLinked List Count is{count}");
            return count;
        }
        public Node LinkedListSorted(Node head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            Node temp = head;
            Node slow = head;
            Node fast = head;
            while(fast!=null&&fast.next != null)
            {
                temp = slow;
                slow=slow.next;
                fast=fast.next.next;
            }
            temp.next = null;
            Node leftside=LinkedListSorted(head);
            Node rightside=LinkedListSorted(slow);
            return Merge(leftside, rightside);
        }
        public Node Merge( Node first,Node second)
        {
            Node sorted_temp = new Node();
            Node current_node = sorted_temp;
            while (first != null && second != null)
            {
                if (first.data < second.data)
                {
                    current_node.next = first;
                    first = first.next;
                }
                else
                {
                    current_node.next = second;
                    second = second.next;   
                }
                current_node = current_node.next;
            }
            if(first != null)
            {
                current_node.next=first;
                first = first.next;
            }
            if(second != null)
            {
                current_node.next=second;
                second = second.next;
            }
            return sorted_temp.next;
        }
    }
}