using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSpan_Prime
{
    class Graph
    {
        int vertice;
        int[,] matrix;
        public Graph(int vertice)

        {
            this.vertice = vertice;
            matrix = new int[vertice, vertice];
        }

        public void AddEdge(int source, int destination, int weight)
        {
            matrix[source, destination] = weight;
            matrix[destination, source] = weight; // back for undirected graph

        }
        int GetMinimumVertex(bool [] miniSpanT, int [] key) // Get the vertex with minimum weight not yet included Mini span
        {
            int minKey = int.MaxValue;
            int vertex = 1;
            for (int i = 0; i < vertice; i++)
            {
                if(miniSpanT[i] == false && minKey > key[i])
                {
                    minKey = key[i];
                    vertex = i;
                }
            }
            return vertex;
        }
        public void MinimumSpanFind()
        {
            bool[] miniSpanTree = new bool[vertice];
            Graphset[] graph = new Graphset[vertice];
            int[] key = new int[vertice];
            for (int i = 0; i < vertice; i++)
            {
                key[i] = int.MaxValue; // initialize all key to infinity
                graph[i] = new Graphset(); // initialize resultSet for all verices
            }

            // starting from zero
            key[0] = 0;
            graph[0] = new Graphset();
            graph[0].Parent = -1; // initializing parent vertex

            //Creating the Mst
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // getting the vertex with the minimum key
                int vertex = GetMinimumVertex(miniSpanTree, key);

                // include the vertex in the MinimumSpanning tree
                miniSpanTree[vertex] = true;  // and set others to false

                // iterating through all the adjacent vertices of the above vertex and updating the key
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //check of the edge
                    if(matrix[vertex,j] > 0)   // not be zero
                    {
                        //check if the node j is in the  mst if not then check if key need update or not
                        if(miniSpanTree[j] == false && matrix[vertex,j] < key[j])    //if vertex not in tree go in bro
                        {
                            // update the key
                            key[j] = matrix[vertex, j];
                            // update the graph result set
                            graph[j].Parent = vertex;
                            graph[j].Weight = key[j];
                        }
                    }
                }
            }
            PrintMinimumSpan(graph);
        }
        public void PrintMinimumSpan(Graphset [] gragh)
        {
            int sumOfMinimumWeight = 0;
            for (int i = 0; i < vertice; i++)
            {
                sumOfMinimumWeight += gragh[i].Weight;
                Console.WriteLine($"Edge : {i} - {gragh[i].Parent}  Cost = {gragh[i].Weight}");
                Console.WriteLine();
             
            }
            Console.WriteLine($"Sum of minimum weight is  {sumOfMinimumWeight}");
        }
    }
}
