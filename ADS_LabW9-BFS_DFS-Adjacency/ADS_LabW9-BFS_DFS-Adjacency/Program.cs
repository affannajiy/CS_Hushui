/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW9_BFS_DFS_Adjacency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++BFS & DFS in Adjacency Matrix++\n");

            char[] nodeLabel = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            GraphMatrix graph = new GraphMatrix(nodeLabel);

            //AddEdge
            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('A', 'D');
            graph.AddEdge('B', 'E');
            graph.AddEdge('C', 'F');
            graph.AddEdge('C', 'G');
            graph.AddEdge('E', 'H');
            graph.AddEdge('F', 'H');
            graph.AddEdge('G', 'H');
            
            //Display
            graph.PrintMatrix();

            //BFS & DFS
            graph.BFS('A');
            graph.DFS('A');
        }
    }
}