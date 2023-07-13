using System.Diagnostics;
using System;
using System.Collections.Generic;
namespace nameSpace
{
    class Program
    {
        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }

        class LinkedList 
        {
            int count;
            LinkedListNode head = null;

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }


            public void PrintList()
            {
                LinkedListNode runner = head;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
            public void Reverse()
            {
                LinkedListNode previous = null;
                LinkedListNode current = head;
                LinkedListNode next = null;

                while (current != null)
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }

                head = previous;
            }
        }



        static void Main(string[] args) 
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(7);
            linkedList.AddNodeToFront(9);
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(4);
            linkedList.AddNodeToFront(21);


            Console.WriteLine("The numbers of the beast are:");

            linkedList.PrintList();

            Console.WriteLine("\n"+"And backwards they are:");
            
            linkedList.Reverse();
            linkedList.PrintList();
        }
    }
}