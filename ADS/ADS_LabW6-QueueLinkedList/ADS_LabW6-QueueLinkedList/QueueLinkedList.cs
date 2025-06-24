/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_QueueLinkedList
{
    class QueueLinkedList
    {
        private Node front;
        private Node rear;

        public QueueLinkedList()
        {
            front = null;
            rear = null;
        }

        //Enqueue
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            Console.WriteLine($"Enqueued: {data}");
        }

        //Dequeue
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Error: Underflow, queue is empty");
                return;
            }

            Console.WriteLine($"Dequeued: {front.Data}");
            front = front.Next;
            if (front == null) //if the queue is empty
            {
                rear = null;
            }
        }

        //Peek
        public void Peek()
        {
            if (front == null)
            {
                Console.WriteLine("Error: Underflow, queue is empty");
                return;
            }
            Console.WriteLine($"Front: {front.Data}");
        }

        //IsEmpty
        public bool IsEmpty()
        {
            return front == null;
        }

        //Display
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Error: Underflow, queue is empty");
                return;
            }

            Node temp = front; //temp to traverse
            Console.WriteLine("\nQueue: ");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine("\n");
        }
    }
}
