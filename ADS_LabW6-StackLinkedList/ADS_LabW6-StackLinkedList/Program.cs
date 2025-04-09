/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_StackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Stack Linked List--\n");
            StackLinkedList stack = new StackLinkedList();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Display();
            stack.Pop();
            stack.Peek();
            stack.Display();
        }
    }
}