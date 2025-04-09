/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Queue Linked List--\n");
            QueueLinkedList queue = new QueueLinkedList();
            queue.Enqueue(1); //1
            queue.Enqueue(2); //1 2
            queue.Enqueue(3); //1 2 3
            queue.Enqueue(4); //1 2 3 4
            queue.Display();  //1 2 3 4
            queue.Dequeue();  //2 3 4   
            queue.Peek();     //2
            queue.Display();  //2 3 4
        }
    }
}