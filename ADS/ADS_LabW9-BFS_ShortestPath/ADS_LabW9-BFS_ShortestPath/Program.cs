/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW9_BFS_ShortestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++Short Path Graph++");

            GraphShortPath graph = new GraphShortPath();

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('A', 'D');
            graph.AddEdge('B', 'E');
            graph.AddEdge('C', 'F');
            graph.AddEdge('C', 'G');
            graph.AddEdge('E', 'H');
            graph.AddEdge('F', 'H');
            graph.AddEdge('G', 'H');

            graph.FindShortPath('A', 'H');
        }
    }
}