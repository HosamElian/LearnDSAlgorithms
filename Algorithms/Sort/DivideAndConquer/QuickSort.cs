namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class QuickSort : ISort
	{
		// time complexity O(n^2) || unstable || In Place
		// space Complexity: O(n)

		public int[] Sort(int[] arr)
		{
			return QuickSortInternal(arr, 0, arr.Length - 1);
		}

		#region Helpers

		private int[] QuickSortInternal(int[] arr, int low, int high)
		{
			if (low < high)
			{
				int pivot = Partition(arr, low, high);

				QuickSortInternal(arr, low, pivot - 1);

				QuickSortInternal(arr, pivot + 1, high);
			}

			return arr;
		}

		private int Partition(int[] arr, int low, int high)
		{
			int pivot = arr[low];

			int i = low + 1;

			int j = high;

			do
			{
				while (i <= j && arr[i] <= pivot)
				{
					i++;
				}

				while (i <= j && arr[j] > pivot)
				{
					j--;
				}

				if (i <= j)
					Swap(arr, i, j);
			} while (i < j);

			Swap(arr, low, j);

			return j;
		}

		private void Swap(int[] arr, int first, int second)
		{
			int temp = arr[first];

			arr[first] = arr[second];

			arr[second] = temp;
		}

		#endregion


		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n²)
		///
		/// Where:
		/// Pivot always creates
		/// unbalanced partitions
		///
		/// Equation:
		/// n + (n−1) + (n−2) + ... + 1
		///
		/// Remove Constants:
		/// O(n²)
		///
		///
		/// Space Complexity:
		/// O(n)
		///
		/// Where:
		/// Recursive calls create
		/// call stack memory.
		///
		/// Memory grows with input size.
		///
		///
		/// Stable:
		/// No
		///
		///
		/// In Place:
		/// Yes
		///
		///
		/// Used:
		/// Sort array by selecting
		/// pivot and partitioning.
		///
		///
		/// Problem:
		///
		/// Need fast average sorting
		/// without extra arrays.
		///
		///
		/// Solution:
		///
		/// Divide and Conquer
		///
		/// Steps:
		///
		/// 1. Select pivot
		/// 2. Partition array
		/// 3. Sort left
		/// 4. Sort right
		///
		///
		/// Example:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Pivot:
		///
		/// 64
		///
		/// Partition:
		///
		/// [11 25 12 22 | 64]
		///
		/// Continue recursively
		///
		/// Result:
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
		/// Pivot
		///
		/// ↓
		///
		/// Left | Right
		///
		/// ↓
		///
		/// Sorted
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Very fast in practice
		/// - In-place sorting
		/// - No extra arrays
		///
		///
		/// Do NOT use:
		/// - When stable sorting is required
		/// - When worst-case guarantees matter
		///
		/// </summary>

		#endregion
	}
}
