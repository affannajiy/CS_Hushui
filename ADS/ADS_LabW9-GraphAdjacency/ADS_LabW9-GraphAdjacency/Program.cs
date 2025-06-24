/*
Name: 'Affan Najiy Bin Rusdi 
ID  : 22010453
*/
using System;

namespace ADS_LabW9_BFS_CFS_Adjacency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++Graph using Adjacency List++\n");

            Graph graph = new Graph();

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('A', 'D');
            graph.AddEdge('B', 'E');
            graph.AddEdge('C', 'F');
            graph.AddEdge('C', 'G');
            graph.AddEdge('E', 'H');
            graph.AddEdge('F', 'H');
            graph.AddEdge('G', 'H');

            Console.WriteLine("Graph Representation (Adjacency List):\n");
            graph.PrintGraph();
        }
    }
}