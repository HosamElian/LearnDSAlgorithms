using System;
using LearnDSAlgorithms.Graphs;

namespace LearnDSAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            Console.WriteLine("Vertices: " + g.VertexCount());
            Console.WriteLine("Edges Count: " + g.EdgeCount());
            g.InsertEdge(0, 1, 1);
            g.InsertEdge(0, 2, 1);
            g.InsertEdge(1, 0, 1);
            g.InsertEdge(1, 2, 1);
            g.InsertEdge(2, 0, 1);
            g.InsertEdge(2, 1, 1);
            g.InsertEdge(2, 3, 1);
            g.InsertEdge(3, 2, 1);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            Console.WriteLine("Vertices: " + g.VertexCount());
            Console.WriteLine("Edges Count: " + g.EdgeCount());
            g.GetEdges();
            Console.WriteLine("Is Edge between 1--3: " + g.ExistEdge(1, 3));
            Console.WriteLine("Is Edge between 1--2: " + g.ExistEdge(1, 2));
            Console.WriteLine("Degree of Vertex 2: " + g.InDegree(2));
            Console.WriteLine("Remove Edge between 1--2");
            g.RemoveEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            Console.WriteLine("Is Edge between 1--2: " + g.ExistEdge(1, 2));
            Console.WriteLine("BreadthFirstSearch: ");
            g.BreadthFirstSearch(0);
            Console.WriteLine();
            Console.WriteLine("DepthFirstSearch: ");
            g.DepthFirstSearch(0);
            Console.WriteLine();
            Console.WriteLine("####### another graph #########");
            Graph g2 = new Graph(7);
            g2.InsertEdge(0, 1, 1);
            g2.InsertEdge(0, 5, 1);
            g2.InsertEdge(0, 6, 1);
            g2.InsertEdge(1, 0, 1);
            g2.InsertEdge(1, 2, 1);
            g2.InsertEdge(1, 5, 1);
            g2.InsertEdge(1, 6, 1);
            g2.InsertEdge(2, 3, 1);
            g2.InsertEdge(2, 4, 1);
            g2.InsertEdge(2, 6, 1);
            g2.InsertEdge(3, 4, 1);
            g2.InsertEdge(4, 2, 1);
            g2.InsertEdge(4, 5, 1);
            g2.InsertEdge(5, 2, 1);
            g2.InsertEdge(5, 3, 1);
            g2.InsertEdge(6, 3, 1);
            Console.WriteLine("BreadthFirstSearch: ");
            g2.BreadthFirstSearch(0);
            Console.WriteLine();
            Console.WriteLine("DepthFirstSearch: ");
            g2.DepthFirstSearch(0);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
