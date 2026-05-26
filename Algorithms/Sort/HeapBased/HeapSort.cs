using LearnDSAlgorithms.Heap;

namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class HeapSort : ISort
	{
		// time complexity O(n log n) || unstable || Not In Place
		// space Complexity: O(n)

		public int[] Sort(int[] arr)
		{
			var heap = new Heap<int>(arr.Length);

			foreach (int item in arr)
			{
				heap.Insert(item);
			}

			var k = heap.Length() - 1;

			for (int i = 0; i < heap.Length(); i++)
			{
				arr[k] = heap.DeleteMax();

				k--;
			}

			return arr;
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n log n)
		///
		/// Where:
		/// Build Heap → n log(n)
		/// Delete Max → n log(n)
		///
		/// Equation:
		/// nlog(n) + nlog(n)
		///
		/// Remove Constants:
		/// O(n log n)
		///
		///
		/// Space Complexity:
		/// O(n)
		///
		/// Where:
		/// Uses additional memory such as:
		/// - Heap object
		/// - Heap internal storage
		///
		/// Memory grows with input size.
		///
		///
		/// Stable:
		/// No
		///
		///
		/// In Place:
		/// No
		///
		///
		/// Used:
		/// Sort array by building
		/// a heap structure and
		/// repeatedly extracting
		/// the maximum value.
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
		/// Need predictable sorting
		/// performance for large inputs.
		///
		///
		/// Solution:
		///
		/// Convert array into:
		///
		/// Max Heap
		///
		/// Then:
		///
		/// Repeatedly remove
		/// largest value.
		///
		///
		/// Steps:
		///
		/// 1. Insert all values into heap
		/// 2. Heap maintains order
		/// 3. Remove maximum value
		/// 4. Place into final array
		/// 5. Repeat until empty
		///
		///
		/// Example:
		///
		/// [64, 25, 12, 22, 11]
		///
		/// Build Heap:
		///
		///       64
		///      /  \
		///    25    12
		///   /  \
		/// 22   11
		///
		/// Remove:
		///
		/// 64
		///
		/// Remaining:
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
		/// ↓
		///
		/// Build Heap
		///
		///       64
		///      /  \
		///    25    12
		///
		/// ↓
		///
		/// Delete Max
		///
		/// ↓
		///
		/// Sorted
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Guaranteed O(n log n)
		/// - Good for large datasets
		/// - Does not degrade like Quick Sort
		///
		///
		/// Do NOT use:
		/// - When stable sorting is required
		/// - When memory usage must remain constant
		///
		/// </summary>

		#endregion
	}
}
