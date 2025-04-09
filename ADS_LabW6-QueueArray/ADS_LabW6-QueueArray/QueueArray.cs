/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_QueueArray
{
    class QueueArray
    {
        private int[] queue;
        private int front;
        private int rear;
        private int maxSize;
        private int count;

        //Constructor
        public QueueArray(int size)
        {
            maxSize = size;
            queue = new int[maxSize];
            front = -1;
            rear = -1;
            count = 0;
        }

        //Enqueue
        public void Enqueue(int data)
        {
            if (rear == maxSize - 1)
            {
                Console.WriteLine("Error: Overflow, queue is full");
                return;
            }
            
            if (front == -1) //if queue is empty
            {
                front = 0;
            }
            rear++;
            queue[rear] = data;
            count++;
            Console.WriteLine($"Enqueued: {data}");
        }

        //Dequeue
        public void Dequeue()
        {
            if (front == -1 || front > rear) //if queue is empty
            {
                Console.WriteLine("Error: Underflow, queue is empty");
            }
            Console.WriteLine($"Dequeued: {queue[front]}"); //remove at front
            front++;
            count--;
        }

        //Peek
        public void Peek()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Error: Queue is empty");
                return;
            }
            Console.WriteLine($"Peek: {queue[front]}");
        }

        //IsEmpty
        public bool IsEmpty()
        {
            return (front == -1 || front > rear);
        }

        //Display
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("\nQueue: ");
            for (int i = front; i <= rear; i++)
            {
                Console.Write($"{queue[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}
