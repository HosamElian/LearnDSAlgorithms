namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class InsertionSort : ISort
	{
		// time complexity O(n^2) || stable || In Place
		// space Complexity: O(1)

		public int[] Sort(int[] arr)
		{
			int arraySize = arr.Length;

			for (int i = 1; i < arraySize; i++)
			{
				int currentValue = arr[i];
				int position = i;

				while (position > 0 && arr[position - 1] > currentValue)
				{
					arr[position] = arr[position - 1];

					position--;
				}

				arr[position] = currentValue;
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
		/// Inner loop → 1 + 2 + 3 + ... + (n−1)
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
		/// - currentValue
		/// - position
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
		/// Sort array by inserting each element
		/// into its correct position.
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
		/// Need sorting while using
		/// constant additional memory.
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
		/// 1. Start from second element
		/// 2. Save current value
		/// 3. Shift larger values right
		/// 4. Insert value in position
		/// 5. Repeat
		///
		///
		/// Example:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Pass 1:
		///
		/// [25, 64, 12, 22, 11]
		///
		/// Pass 2:
		///
		/// [12, 25, 64, 22, 11]
		///
		/// Pass 3:
		///
		/// [12, 22, 25, 64, 11]
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
		/// [64 | 25 12 22 11]
		///
		/// Shift → Insert
		///
		/// [25 64 | 12 22 11]
		///
		/// Shift → Insert
		///
		/// [12 25 64 | 22 11]
		///
		/// Completed
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Stable sorting
		/// - Simple implementation
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
