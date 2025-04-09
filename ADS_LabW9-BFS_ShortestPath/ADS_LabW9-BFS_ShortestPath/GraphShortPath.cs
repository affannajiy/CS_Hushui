/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW9_BFS_ShortestPath
{
    class GraphShortPath
    {
        private Dictionary<char, List<char>> adjList;

        //Constructor
        public GraphShortPath()
        {
            adjList = new Dictionary<char, List<char>>();
        }

        //AddEdge
        public void AddEdge(char node, char neighbor) //node is the key, neighbor is the value
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
            adjList[neighbor].Add(node);
        }

        //FindShortPath (BFS)
        public void FindShortPath(char start, char target)
        {
            Queue<char> queue = new Queue<char>();
            Dictionary<char, char> parent = new Dictionary<char, char>(); 
            HashSet<char> visited = new HashSet<char>(); //HashSet is used to check if a node has been visited

            queue.Enqueue(start);
            visited.Add(start);
            parent[start] = '\0';

            while (queue.Count > 0)
            {
                char node = queue.Dequeue();

                if (node == target)
                {
                    PrintPath(parent, start, target);
                    return;
                }

                foreach (char neighbour in adjList[node])
                {
                    if (!visited.Contains(neighbour))
                    {
                        queue.Enqueue(neighbour);
                        visited.Add(neighbour);
                        parent[neighbour] = node;
                    }
                }
            }
            Console.WriteLine();
        }

        //PrintPath
        public void PrintPath(Dictionary<char, char> parent, char start, char target)
        {
            Stack<char> path = new Stack<char>();
            char current = target;

            while (current != '\0')
            {
                path.Push(current);
                current = parent[current];
            }

            Console.WriteLine("--Shortest Path--");

            while (path.Count > 1)
            {
                Console.Write(path.Pop() + " -> ");
            }
            Console.WriteLine(target);
        }
    }
}
