/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/

using System;

namespace ADS_LabW7_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            Console.WriteLine("----Binary Tree---\n");

            int[] datas = { 50, 30, 70, 20, 40, 60, 80 };

            foreach (int data in datas)
            {
                tree.Insert(data);
            }

            Console.WriteLine("Display Tree: \n");
            tree.DisplayTree(tree.Root);
            Console.WriteLine("\n");

            Console.WriteLine("Pre-Order (Root, L, R): ");
            tree.PreOrder(tree.Root);
            Console.WriteLine("\n");

            Console.WriteLine("In-Order (L, Root, R): ");
            tree.InOrder(tree.Root);
            Console.WriteLine("\n");

            Console.WriteLine("Post-Order (L, R, Root): ");
            tree.PostOrder(tree.Root);
            Console.WriteLine("\n");
        }
    }
}