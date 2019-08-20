using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSpan_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);
            graph.AddEdge(0,1,11);
            graph.AddEdge(0,2,12);
            graph.AddEdge(0,4,40);
            graph.AddEdge(0,3,28);
            graph.AddEdge(1,2,20);
            graph.AddEdge(1,3,35);
            graph.AddEdge(1,4,18);
            graph.AddEdge(1,0,11);
            graph.AddEdge(2,1,20);
            graph.AddEdge(2,0,12);
            graph.AddEdge(2,3,14);
            graph.AddEdge(2,4,10);
            graph.AddEdge(3,0,28);
            graph.AddEdge(3,1,35);
            graph.AddEdge(3,2,14);
            graph.AddEdge(4,1,18);
            graph.AddEdge(4,2,10);
            graph.AddEdge(4,0,40);

            graph.MinimumSpanFind();
            Console.ReadKey();
        }
    }
}
