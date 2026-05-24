using System;
using System.Collections.Generic;

namespace LearnDSAlgorithms.Graphs
{
	public class Graph
	{
		int _verticesCount;
		int[,] adjMat;

		public Graph(int n)
		{
			_verticesCount = n;
			adjMat = new int[n, n];
		}

		public void InsertEdge(int fromVertex, int toVertex, int cost = 1)
		{
			adjMat[fromVertex, toVertex] = cost;
		}
		public int RemoveEdge(int fromVertex, int toVertex)
		{
			return adjMat[fromVertex, toVertex] = 0;
		}
		public bool ExistEdge(int fromVertex, int toVertex)
		{
			return adjMat[fromVertex, toVertex] != 0;
		}
		public int VertexCount()
		{
			return _verticesCount;
		}
		public int EdgeCount()
		{
			int count = 0;
			for (int i = 0; i < _verticesCount; i++)
			{
				for (int j = 0; j < _verticesCount; j++)
				{
					if (adjMat[i, j] != 0)
						count++;
				}
			}
			return count;
		}
		public void GetEdges()
		{
			for (int i = 0; i < _verticesCount; i++)
			{
				for (int j = 0; j < _verticesCount; j++)
				{
					if (adjMat[i, j] != 0)
						Console.WriteLine($"{i} -- {j}");
				}
			}
		}
		public int OutDegree(int vertex)
		{
			int count = 0;
			for (int i = 0; i < _verticesCount; i++)
			{
				if (adjMat[vertex, i] != 0)
				{
					count++;
				}
			}
			return count;
		}
		public int InDegree(int vertex)
		{
			int count = 0;
			for (int i = 0; i < _verticesCount; i++)
			{
				if (adjMat[i, vertex] != 0)
				{
					count++;
				}
			}
			return count;
		}
		public void Display()
		{
			for (int i = 0; i < _verticesCount; i++)
			{
				for (int j = 0; j < _verticesCount; j++)
					Console.Write(adjMat[i, j] + "\t");
				Console.WriteLine();
			}
		}

		public void BreadthFirstSearch(int root)
		{
			if (root > _verticesCount)
			{
				Console.WriteLine("Node has no neighbor node");
				return;
			}
			Queue<int> queue = new Queue<int>();
			var visited = new bool[_verticesCount];
			visited[root] = true;
			queue.Enqueue(root);
			Console.Write(root + " ");
			while (queue.Count > 0)
			{
				int node = queue.Dequeue();
				for (int neighbor = 0; neighbor < _verticesCount; neighbor++)
				{
					if (adjMat[node, neighbor] == 1 && !visited[neighbor])
					{
						Console.Write(neighbor + " ");
						queue.Enqueue(neighbor);
						visited[neighbor] = true;
					}
				}
			}
		}
		public void DepthFirstSearch(int node)
		{
			if (node > _verticesCount)
			{
				Console.WriteLine("Node has no neighbor node");
				return;
			}
			var visited = new bool[_verticesCount];
			depthFirstSearch(node, visited);
		}
		private void depthFirstSearch(int node, bool[] visited)
		{
			Console.Write(node + " ");
			visited[node] = true;
			for (int neighbor = 0; neighbor < _verticesCount; neighbor++)
				if (adjMat[node, neighbor] == 1 && !visited[neighbor])
					depthFirstSearch(neighbor, visited);
		}

	}
}
