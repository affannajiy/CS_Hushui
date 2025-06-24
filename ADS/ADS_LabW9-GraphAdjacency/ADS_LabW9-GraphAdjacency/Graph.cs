/*
Name: 'Affan Najiy Bin Rusdi 
ID  : 22010453
*/
using System;

namespace ADS_LabW9_BFS_CFS_Adjacency
{
    class Graph
    {
        private Dictionary<char, List<char>> adjList;

        // Constructor
        public Graph()
        {
            adjList = new Dictionary<char, List<char>>();
        }

        //AddEdge
        public void AddEdge(char node, char neighbor) //node is the parent, neighbor is the child
        {
            if (!adjList.ContainsKey(node))
            {
                adjList[node] = new List<char>();
            }
            adjList[node].Add(neighbor);

            if (!adjList.ContainsKey(neighbor))
            {
                adjList[neighbor] = new List<char>();
            }
            adjList[neighbor].Add(node); //undirected
        }

        //Display
        public void PrintGraph()
        {
            foreach (var node in adjList)
            {
                Console.Write(node.Key + " -> ");
                foreach (var neighbor in node.Value)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}