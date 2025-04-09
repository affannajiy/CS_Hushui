/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/

using System;

namespace ADS_LabW7_Tree
{
    class BinaryTree
    {
        public Node Root;

        //Pre-Order (Root, L, R)
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        //In-Order (L, Root, R)
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Data + " ");
                InOrder(node.Right);
            }
        }

        //Post-Order (L, R, Root)
        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Data + " ");
            }
        }

        //Insert Node to Binary Nodes
        public Node Insert(Node root, int data)
        {
            if (root == null) //If the tree is empty
            {
                return new Node(data);
            }

            if (data < root.Data) //If the data is less than root
            {
                root.Left = Insert(root.Left, data);
            }

            else if (data > root.Data) //If the data is greater than root
            {
                root.Right = Insert(root.Right, data);
            }

            return root;
        }

        //Insert Method
        public void Insert(int data)
        {
            Root = Insert(Root, data);
        }

        //Display Tree
        public void DisplayTree(Node node, int space = 0)
        {
            if (node != null)
            {
                DisplayTree(node.Right, space + 4); //space is for indentation
                Console.WriteLine(new string(' ', space) + node.Data);
                DisplayTree(node.Left, space + 4);
            }
        }
    }
}