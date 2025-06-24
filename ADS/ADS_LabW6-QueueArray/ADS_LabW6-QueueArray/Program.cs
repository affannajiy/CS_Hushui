/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_QueueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueArray queue = new QueueArray(5);

            Console.WriteLine("--Queue using Array--\n");
            queue.Enqueue(1); //1
            queue.Enqueue(2); //1 2
            queue.Enqueue(3); //1 2 3
            queue.Enqueue(4); //1 2 3 4
            queue.Enqueue(5); //1 2 3 4 5
            queue.Display();  //1 2 3 4 5
            queue.Dequeue();  //2 3 4 5
            queue.Peek();     //2
            queue.Display();  //2 3 4 5
        }
    }
}