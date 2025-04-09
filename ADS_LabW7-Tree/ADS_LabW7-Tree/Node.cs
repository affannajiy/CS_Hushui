/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/

using System;

namespace ADS_LabW7_Tree
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        //Constructor
        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}