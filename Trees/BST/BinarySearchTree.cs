using System;
using System.Collections.Generic;

namespace LearnDSAlgorithms.Trees.BST
{
	public sealed class BinarySearchTree<T>
		where T : IComparable<T>
	{
		public BSTNode<T> Root { get; set; } = null;

		public int FindHeight()
		{
			return height(Root);
		}

		private int height(BSTNode<T> root)
		{
			if (root == null) return -1;

			var leftHeight = height(root.Left);
			var rightHeight = height(root.Right);

			return leftHeight > rightHeight ? (leftHeight +1): (rightHeight + 1);
		}

		#region Count 
		public int Count()
		{
			return count(Root);
		}
		private int count(BSTNode<T> root)
		{
			if (root != null)
			{
				var leftCount = count(root.Left);
				var rightCount = count(root.Right);
				return leftCount + rightCount + 1;
			}
			return 0;

		}
		#endregion
		#region Insert 
		//time complexity O (h) where h is height of tree 
		public void InsertRecursive(T item)
		{
			Root = insertRecursive(Root, item);
		}
		private BSTNode<T> insertRecursive(BSTNode<T> current, T item)
		{
			if (current == null)
			{
				return new BSTNode<T>(item, null, null);
			}

			int comparison = item.CompareTo(current.Value);

			if (comparison < 0)
			{
				current.Left = insertRecursive(current.Left, item);
			}
			else if (comparison > 0)
			{
				current.Right = insertRecursive(current.Right, item);
			}
			return current;
		}
		#endregion
		#region Delete
		//time complexity O (h) where h is height of tree 
		public BSTNode<T> Delete(T item)
		{
			return delete(Root, item);
		}
		private BSTNode<T> delete(BSTNode<T> root, T item)
		{
			if (root == null) return null;
			if (root.Value.CompareTo(item) > 0)
			{
				root.Left = delete(root.Left, item);
			}
			else if (root.Value.CompareTo(item) < 0)
			{
				root.Right = delete(root.Right, item);
			}
			else
			{
				// Case 1: No child => just remove it
				if (root.HasNoChildren()) return null;

				// Case 2: One child => make the child take place
				if (root.Left == null) return root.Right;
				if (root.Right == null) return root.Left;
				// Case 3: Two children
				//Find the in-order successor (smallest value in the right subtree).
				BSTNode<T> minNode = root.Right;
				while (minNode.Left != null)
					minNode = minNode.Left;
				//Replace the value of the node to delete with the in-order successor.
				root.Value = minNode.Value;
				//Delete the in-order successor(which will fall into Case 1 or 2).
				root.Right = delete(root.Right, minNode.Value);
			}
			return root;
		}
		#endregion
		#region Traversal
		public void InOrderTraversal()
		{
			inOrderTraversal(Root);
		}
		private void inOrderTraversal(BSTNode<T> root)
		{
			if (root == null)
				return;
			inOrderTraversal(root.Left);
			Console.Write($"{root.Value} ");
			inOrderTraversal(root.Right);
		}
		public void PreOrderTraversal()
		{
			preOrderTraversal(Root);
		}
		private void preOrderTraversal(BSTNode<T> root)
		{
			if (root == null)
				return;

			Console.Write($"{root.Value} ");
			preOrderTraversal(root.Left);
			preOrderTraversal(root.Right);
		}

		public void PostOrderTraversal()
		{
			postOrderTraversal(Root);
		}
		private void postOrderTraversal(BSTNode<T> root)
		{
			if (root == null)
				return;

			postOrderTraversal(root.Left);
			postOrderTraversal(root.Right);
			Console.Write($"{root.Value} ");
		}

		public void LevelOrderTraversal()
		{
			if (Root == null) return;
			var tRoot = Root;
			var queue = new Queue<BSTNode<T>>();
			Console.WriteLine(tRoot.Value);
			queue.Enqueue(tRoot);
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
				if (current.Left != null)
				{
					Console.Write(current.Left.Value);
					queue.Enqueue(current.Left);
				}
				if (current.Right != null)
				{
					Console.Write(current.Right.Value);
					queue.Enqueue(current.Right);
				}
				Console.WriteLine("");
			}
		}
		#endregion
		#region Search
		//time complexity O (h) where h is height of tree 
		public bool SearchRecursive(T SearchItem)
		{
			var current = Root;
			return SearchRecursiveInternal(current, SearchItem);
		}
		private bool SearchRecursiveInternal(BSTNode<T> current, T SearchItem)
		{
			if (current != null)
			{
				if (current.Value.CompareTo(SearchItem) == 0)
				{
					return true;
				}
				else if (current.Value.CompareTo(SearchItem) > 0)
				{
					return SearchRecursiveInternal(current.Left, SearchItem);
				}
				else if (current.Value.CompareTo(SearchItem) < 0)
				{
					return SearchRecursiveInternal(current.Right, SearchItem);
				}
			}
			return false;
		}
		//time complexity O(h) where h is height of tree 
		// height of tree is number of edges in path 
		public void InsertIterative(T item)
		{
			var newNode = new BSTNode<T>(item, null, null);

			if (Root == null)
			{
				Root = newNode;
				return;
			}
			var current = Root;
			BSTNode<T> parent = null;
			while (current != null)
			{
				parent = current;
				if (item.CompareTo(current.Value) == 0)
				{
					return;
				}
				else if (item.CompareTo(current.Value) > 0)
				{
					current = current.Right;
				}
				else if (item.CompareTo(current.Value) < 0)
				{
					current = current.Left;
				}
			}
			if (item.CompareTo(parent.Value) < 0)
			{
				parent.Left = newNode;
			}
			else
			{
				parent.Right = newNode;
			}

		}
		public bool SearchIterative(T SearchItem)
		{
			var current = Root;
			while (current != null)
			{
				if (current.Value.CompareTo(SearchItem) == 0)
				{
					return true;
				}
				else if (current.Value.CompareTo(SearchItem) > 0)
				{
					current = current.Left;
				}
				else if (current.Value.CompareTo(SearchItem) < 0)
				{
					current = current.Right;
				}
			}
			return false;
		}
		#endregion
	}
}
