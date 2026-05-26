namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class SelectionSort : ISort
	{
		// time complexity O(n^2) || unstable || In Place
		// space Complexity: O (1)
		public int[] Sort(int[] arr)
		{
			int arraySize = arr.Length;
			for (int i = 0; i < arraySize; i++)
			{
				int lowestValueIndex = i;
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[lowestValueIndex])
						lowestValueIndex = j;
				}
				int temp = arr[i];
				arr[i] = arr[lowestValueIndex];
				arr[lowestValueIndex] = temp;
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
		/// Inner loop → n + (n−1) + (n−2) + ... + 1
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
		/// - lowestValueIndex
		/// - loop variables
		///
		/// Memory does not grow with input size.
		///
		/// Used:
		/// Sort array by repeatedly selecting
		/// the smallest element and placing it
		/// in its correct position.
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
		/// We need a simple sorting algorithm
		/// without using additional memory.
		///
		///
		/// Solution:
		///
		/// Divide array into:
		///
		/// Sorted Part
		/// Unsorted Part
		///
		/// Steps:
		///
		/// 1. Assume current index contains minimum
		/// 2. Search remaining elements
		/// 3. Find actual minimum
		/// 4. Swap values
		/// 5. Move to next position
		///
		///
		/// Example:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Pass 1:
		/// Find 11
		///
		/// [11, 25, 12, 22, 64]
		///
		/// Pass 2:
		/// Find 12
		///
		/// [11, 12, 25, 22, 64]
		///
		/// Pass 3:
		/// Find 22
		///
		/// [11, 12, 22, 25, 64]
		///
		///
		/// Diagram:
		///
		/// Initial
		///
		/// [64 | 25 12 22 11]
		///
		/// Select Min → Swap
		///
		/// [11 | 25 12 22 64]
		///
		/// Select Min → Swap
		///
		/// [11 12 | 25 22 64]
		///
		/// Select Min → Swap
		///
		/// [11 12 22 | 25 64]
		///
		/// Completed
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Simple implementation
		/// - Uses constant memory
		/// - Easy to understand
		///
		///
		/// Do NOT use:
		/// - Large datasets
		/// - Performance critical applications
		/// - When stable sorting is required
		///
		/// </summary>
		#endregion
	}
}
