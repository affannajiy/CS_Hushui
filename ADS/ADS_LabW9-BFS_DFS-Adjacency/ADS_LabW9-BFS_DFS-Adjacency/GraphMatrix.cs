/*
Name: 'Affan Najiy Bin Rusdi
ID  : 22010453
*/
using System;

namespace ADS_LabW9_BFS_DFS_Adjacency
{
    class GraphMatrix
    {
        private char[] nodes; //to store nodes
        private int[,] adjMatrix;
        private int size;

        // Constructor
        public GraphMatrix(char[] nodeLabel)
        {
            nodes = nodeLabel;
            size = nodes.Length;
            adjMatrix = new int[size, size];
        }

        //AddEdge
        public void AddEdge(char u, char v) //u is source, v is destination
        {
            int i = Array.IndexOf(nodes, u);
            int j = Array.IndexOf(nodes, v);
            adjMatrix[i, j] = 1;

            if (i == -1 || j == -1)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            adjMatrix[j, i] = 1;
            adjMatrix[i, j] = 1; //undirected
        }

        //BFS
        public void BFS(char sourceNode) //sourceNode is the starting node
        {
            int sourceIndex = Array.IndexOf(nodes, sourceNode);
            if (sourceIndex == -1)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            bool[] visited = new bool[size];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(sourceIndex);
            visited[sourceIndex] = true;

            Console.WriteLine("\n--Breadth First Search--");
            while (queue.Count > 0)
            {
                int nodeIndex = queue.Dequeue();
                Console.Write(nodes[nodeIndex] + " ");

                for (int i = 0; i < size; i++)
                {
                    if (adjMatrix[nodeIndex, i] == 1 && !visited[i])
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
            Console.WriteLine();
        }

        //DFS
        public void DFS(char sourceNode)
        {
            int sourceIndex = Array.IndexOf(nodes, sourceNode);
            if (sourceIndex == -1)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            bool[] visited = new bool[size];
            Stack<int> stack = new Stack<int>();
            stack.Push(sourceIndex);

            Console.WriteLine("\n--Depth First Search--");
            while (stack.Count > 0)
            {
                int nodeIndex = stack.Pop();
                Console.Write(nodes[nodeIndex] + " ");
                visited[nodeIndex] = true;

                for (int i = size - 1; i >= 0; i--) //Reverse
                {
                    if (adjMatrix[nodeIndex, i] == 1 && !visited[i])
                    {
                        stack.Push(i);
                    }
                }
            }
            Console.WriteLine();
        }

        //Display
        public void PrintMatrix()
        {
            Console.WriteLine("--Adjacency Matrix--");
            Console.Write("  ");
            foreach (char node in nodes)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < size; i++)
            {
                Console.Write(nodes[i] + " ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(adjMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
