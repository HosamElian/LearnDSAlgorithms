using LearnDSAlgorithms.SortAlgorithms;
using System;

namespace LearnDSAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 42, 32, 33, 52, 37, 47, 51 };
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", numbers));
            var sort = new RadixSort();
            var sortedList = sort.Sort(numbers);
            foreach ( var item in sortedList )
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
