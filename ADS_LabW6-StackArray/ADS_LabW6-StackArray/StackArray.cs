/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_StackArray
{
    class StackArray
    {
        private int[] stack;
        private int top;
        private int maxSize;

        //Constructor
        public StackArray(int size)
        {
            maxSize = size;
            stack = new int[maxSize];
            top = -1;
        }

        //Push
        public void Push(int data)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Error: Overflow, stack is full");
                return;
            }

            stack[++top] = data;
            Console.WriteLine($"Pushed: {data}");
        }

        //Pop
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Error: Underflow, stack is empty");
                return;
            }
            Console.WriteLine($"Popped: {stack[top--]}"); //top is decremented
        }

        //Peek
        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Error: Stack is empty");
                return;
            }
            Console.WriteLine($"Peek: {stack[top]}");
        }

        //IsEmpty
        public bool IsEmpty()
        {
            return top == -1;
        }

        //Display
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            
            Console.WriteLine("\nStack: ");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
