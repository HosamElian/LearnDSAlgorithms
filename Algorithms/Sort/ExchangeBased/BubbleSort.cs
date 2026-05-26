namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class BubbleSort : ISort
	{
		// time complexity O(n^2) || stable || In Place
		// space Complexity: O(1)

		public int[] Sort(int[] arr)
		{
			int arraySize = arr.Length;

			for (int i = arraySize - 1; i >= 0; i--)
			{
				for (int j = 0; j < i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];

						arr[j] = arr[j + 1];

						arr[j + 1] = temp;
					}
				}
			}

			return arr;
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n²)
		///
		/// Where:
		/// Outer loop → n iterations
		/// Inner loop → (n−1) + (n−2) + ... + 1
		///
		/// Equation:
		/// n(n−1)/2
		///
		/// Remove Constants:
		/// O(n²)
		///
		///
		/// Space Complexity:
		/// O(1)
		///
		/// Where:
		/// Uses only fixed variables such as:
		/// - temp
		/// - loop variables
		///
		/// Memory does not grow with input size.
		///
		///
		/// Stable:
		/// Yes
		///
		///
		/// In Place:
		/// Yes
		///
		///
		/// Used:
		/// Sort array by repeatedly comparing
		/// adjacent values and swapping them.
		///
		///
		/// Problem:
		///
		/// Given:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Need:
		///
		/// [11, 12, 22, 25, 64]
		///
		/// Need a simple sorting algorithm
		/// that modifies the same array.
		///
		///
		/// Solution:
		///
		/// Repeat passes:
		///
		/// Compare Adjacent Elements
		/// Swap If Necessary
		///
		/// Steps:
		///
		/// 1. Compare neighbors
		/// 2. Swap incorrect order
		/// 3. Largest value moves right
		/// 4. Repeat until sorted
		///
		///
		/// Example:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Pass 1:
		///
		/// [25, 12, 22, 11, 64]
		///
		/// Pass 2:
		///
		/// [12, 22, 11, 25, 64]
		///
		/// Pass 3:
		///
		/// [12, 11, 22, 25, 64]
		///
		/// Pass 4:
		///
		/// [11, 12, 22, 25, 64]
		///
		///
		/// Diagram:
		///
		/// Initial
		///
		/// [64 25 12 22 11]
		///
		/// Compare → Swap
		///
		/// [25 12 22 11 | 64]
		///
		/// Compare → Swap
		///
		/// [12 11 22 | 25 64]
		///
		/// Completed
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Stable sorting
		/// - Easy to implement
		/// - Uses constant memory
		///
		///
		/// Do NOT use:
		/// - Large datasets
		/// - Performance critical applications
		///
		/// </summary>

		#endregion
	}
}
