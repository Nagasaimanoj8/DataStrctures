﻿using System;
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
           // LinkedList<int> my_line = new LinkedList<int>();
           // my_line.AddLast(10);
            // my_line.AddLast(70);
             //my_line.AddFirst(300);
            CustomLinkedList linkedList= new CustomLinkedList();
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
              Console.ReadLine();                      
        }
           

        }

    }