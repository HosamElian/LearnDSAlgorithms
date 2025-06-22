using System;

namespace LearnDSAlgorithms.Trees.BST
{
	public sealed class BSTNode<T>
		where T : IComparable<T>
	{
		public BSTNode(T value, BSTNode<T> left, BSTNode<T> right)
		{
			Value = value;
			Left = left;
			Right = right;
		}

		public T Value { get; set; }
		public BSTNode<T> Left { get; set; }
		public BSTNode<T> Right { get; set; }

		public bool HasNoChildren() => Left == null && Right == null;
	}
}
