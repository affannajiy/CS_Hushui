/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW6_StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Stack Array--\n");
            StackArray stack = new StackArray(5);
            stack.Push(1); //1
            stack.Push(2); //2 1
            stack.Push(3); //3 2 1
            stack.Push(4); //4 3 2 1
            stack.Push(5); //5 4 3 2 1
            stack.Display(); //5 4 3 2 1
            stack.Pop();   //4 3 2 1
            stack.Peek();  //4
            stack.Display(); //4 3 2 1
        }
    }
}