using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
            //  LinkedList<int> my_line = new LinkedList<int>();
            //my_line.AddLast(10);
            //my_line.AddLast(70);
            //my_line.AddFirst(30);
            //CustomLinkedList linkedList = new CustomLinkedList();
            //linkedList.AddAtLast(56);
            //linkedList.AddAtLast(30);
            //linkedList.AddAtLast(70);
            // linkedList.Display();
            //CustomLinkedList linkedList = new CustomLinkedList();
            //linkedList.AddAtFirst(70);
            //linkedList.AddAtFirst(30);
            //linkedList.AddAtFirst(56);
            //linkedList.Display();
            //Console.ReadLine();
            CustomLinkedList linkedList = new CustomLinkedList();
            //linkedList.Append(56);
            //linkedList.Append(30);
            //linkedList.Append(70);
            //linkedList.Display();
            //Console.ReadLine();
            linkedList.AddAtLast(56);//adding data in list
            linkedList.AddAtLast(30);//adding data in list
            linkedList.AddAtLast(40);//adding data in list
            linkedList.AddAtLast(70);//adding data in list
            linkedList.Display();    //call display method to print data
            Console.WriteLine("\n");
            linkedList.head=linkedList.LinkedListSorted(linkedList.head);//call LinkedListSort Method passing head
            // linkedList.InsertAfterValue(30, 40);//call InsertAtAfterValue Pass value
          //  linkedList.DeleteElement(40);//call DeleteElement method pass parameter
           // linkedList.InsertAtParticularPosition(2, 30);
           // Console.WriteLine("\n{0}is deleted from the Linkedlist",linkedList.DeleteFirstNode());
            //Console.WriteLine("\n{0} is deleted from linkedlist",linkedList.DeleteLastNode());
            linkedList.Display();
            linkedList.Count();//call count method and print count
            //Console.WriteLine("\n{0} is present", linkedList.Search(30));
            Console.ReadLine();

        }


        }

    }
