using System;
using LearnDSAlgorithms.Quere;
using LearnDSAlgorithms.Trees.BST;

namespace LearnDSAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertRecursive(4);
            binarySearchTree.InsertIterative(1);
            binarySearchTree.InsertRecursive(5);
            binarySearchTree.InsertIterative(3);
            binarySearchTree.InsertIterative(2);
            binarySearchTree.InsertRecursive(6);

            binarySearchTree.InOrderTraversal();
            Console.WriteLine("######################");
            binarySearchTree.PreOrderTraversal();
            Console.WriteLine("######################");
            binarySearchTree.PostOrderTraversal();
			Console.WriteLine("######################");
			binarySearchTree.LevelOrderTraversal();
			Console.WriteLine("######################");
            Console.WriteLine($"Count {binarySearchTree.Count()}");
			Console.WriteLine("######################");
            binarySearchTree.Delete(5);
            Console.WriteLine($"Count {binarySearchTree.Count()}");
            Console.WriteLine($"Height {binarySearchTree.FindHeight()}");


			Console.ReadKey();
        }
    }
}
