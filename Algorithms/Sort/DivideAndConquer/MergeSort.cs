using System;

namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class MergeSort : ISort
	{
		// time complexity O(n log n) || stable
		// space Complexity: O(n)

		public int[] Sort(int[] arr)
		{
			int arraySize = arr.Length;

			if (arraySize <= 1)
				return arr;

			int mid = arraySize / 2;

			int[] left = new int[mid];

			Array.Copy(arr, 0, left, 0, mid);

			int[] right = new int[arraySize - mid];

			Array.Copy(arr, mid, right, 0, arraySize - mid);

			Sort(left);

			Sort(right);

			return Merge(arr, left, right);
		}

		#region Helpers

		private int[] Merge(int[] result, int[] left, int[] right)
		{
			int leftIndex = 0;

			int rightIndex = 0;

			int finalIndex = 0;

			while (leftIndex < left.Length && rightIndex < right.Length)
			{
				if (left[leftIndex] <= right[rightIndex])
				{
					result[finalIndex++] = left[leftIndex++];
				}
				else
				{
					result[finalIndex++] = right[rightIndex++];
				}
			}

			while (leftIndex < left.Length)
				result[finalIndex++] = left[leftIndex++];

			while (rightIndex < right.Length)
				result[finalIndex++] = right[rightIndex++];

			return result;
		}

		#endregion


		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n log n)
		///
		/// Where:
		/// Divide array → log(n)
		/// Merge operation → n
		///
		/// Equation:
		/// n × log(n)
		///
		/// Remove Constants:
		/// O(n log n)
		///
		///
		/// Space Complexity:
		/// O(n)
		///
		/// Where:
		/// Uses additional arrays such as:
		/// - left
		/// - right
		///
		/// Memory grows with input size.
		///
		///
		/// Stable:
		/// Yes
		///
		///
		/// In Place:
		/// No
		///
		///
		/// Used:
		/// Sort array by dividing into
		/// smaller arrays then merging.
		///
		///
		/// Problem:
		///
		/// Large datasets become slow
		/// with quadratic algorithms.
		///
		///
		/// Solution:
		///
		/// Divide and Conquer
		///
		/// Steps:
		///
		/// 1. Divide array
		/// 2. Sort recursively
		/// 3. Merge results
		///
		///
		/// Example:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Split:
		///
		/// [64 25]
		/// [12 22 11]
		///
		/// Merge:
		///
		/// [11 12 22 25 64]
		///
		///
		/// Diagram:
		///
		/// [64 25 12 22 11]
		///
		/// ↓
		///
		/// [64 25]
		/// [12 22 11]
		///
		/// ↓
		///
		/// Merge
		///
		/// ↓
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Stable sorting
		/// - Efficient for large datasets
		/// - Predictable performance
		///
		///
		/// Do NOT use:
		/// - Memory constrained systems
		///
		/// </summary>

		#endregion
	}
}
