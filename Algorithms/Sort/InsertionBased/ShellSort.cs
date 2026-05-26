namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class ShellSort : ISort
	{
		// time complexity O(n^2) || unstable || In Place
		// space Complexity: O(1)

		public int[] Sort(int[] arr)
		{
			int arraySize = arr.Length;

			for (int gap = arraySize / 2; gap > 0; gap /= 2)
			{
				for (int i = gap; i < arraySize; i++)
				{
					int temp = arr[i];

					int j;

					for (j = i; j >= gap && temp < arr[j - gap]; j -= gap)
					{
						arr[j] = arr[j - gap];
					}

					arr[j] = temp;
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
		/// Multiple insertion sort passes
		/// are executed using decreasing gaps
		///
		/// Equation:
		/// n × n
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
		/// - gap
		/// - temp
		/// - j
		///
		/// Memory does not grow with input size.
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
		/// Improve insertion sort by
		/// comparing distant elements first.
		///
		///
		/// Problem:
		///
		/// Insertion sort becomes slow
		/// for large unsorted arrays.
		///
		///
		/// Solution:
		///
		/// Sort elements using gaps
		/// then reduce gap gradually.
		///
		/// Steps:
		///
		/// 1. Select gap
		/// 2. Perform insertion sort
		/// 3. Reduce gap
		/// 4. Finish at gap = 1
		///
		///
		/// Example:
		///
		/// Gap = 3
		///
		/// [64 25 12 22 11]
		///
		/// Gap = 1
		///
		/// [11 12 22 25 64]
		///
		///
		/// Diagram:
		///
		/// Gap = 2
		///
		/// [64 _ 12 _ 11]
		///
		/// Gap = 1
		///
		/// [11 12 22 25 64]
		///
		///
		/// Advantage:
		/// - Faster than insertion sort
		/// - Uses constant memory
		///
		///
		/// Do NOT use:
		/// - When stable sorting is required
		/// - When guaranteed complexity is needed
		///
		/// </summary>

		#endregion
	}
}
