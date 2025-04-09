/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_StackLinkedList
{
    class StackLinkedList
    {
        private Node top;

        //Constructor
        public StackLinkedList()
        {
            top = null;
        }

        //Push
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            Console.WriteLine($"Push: {data}");
        }

        //Pop
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Error: Underflow, stack is empty");
                return;
            }
            Console.WriteLine($"Pop: {top.Data}");
            top = top.Next; //move top to next node
        }

        //Peek
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Error: Stack is empty");
                return;
            }
            Console.WriteLine($"Peek: {top.Data}");
        }

        //IsEmpty
        public bool IsEmpty()
        {
            return top == null;
        }

        //Display
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("\nStack:");
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
