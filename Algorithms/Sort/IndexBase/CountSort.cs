namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class CountSort : ISort
	{
		// time complexity O(n) || stable || Not In Place
		// space Complexity: O(n)

		public int[] Sort(int[] arr)
		{
			if (arr == null || arr.Length == 0)
				return arr;

			int i = 0,
				j = 0;

			var maxSize = GetMax(arr);

			var sortedArray = new int[maxSize + 1];

			for (i = 0; i < arr.Length; i++)
			{
				sortedArray[arr[i]]++;
			}

			i = 0;

			while (i < (maxSize + 1))
			{
				if (sortedArray[i] > 0)
				{
					arr[j++] = i;
					sortedArray[i]--;
				}
				else
				{
					i++;
				}
			}

			return arr;
		}

		private int GetMax(int[] arr)
		{
			int max = 0;

			foreach (var item in arr)
			{
				if (item.CompareTo(max) > 0)
					max = item;
			}

			return max;
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n + k)
		///
		/// Where:
		/// Step 1 (count elements) → O(n)
		/// Step 2 (iterate count array) → O(k)
		///
		/// k = max value in array
		///
		/// Equation:
		/// O(n + k)
		///
		/// Remove Constants:
		/// O(n)
		///
		///
		/// Space Complexity:
		/// O(n)
		///
		/// Where:
		/// Uses extra array:
		/// - sortedArray (frequency array)
		///
		/// Memory grows with input range.
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
		/// Count frequency of each value
		/// then rebuild sorted array.
		///
		///
		/// Problem:
		///
		/// Need fast sorting for integers
		/// within a known range.
		///
		///
		/// Solution:
		///
		/// 1. Count occurrences
		/// 2. Store frequencies
		/// 3. Rebuild array in order
		///
		///
		/// Example:
		///
		/// [4, 2, 2, 8, 3]
		///
		/// Count:
		///
		/// 2 → 2 times
		/// 3 → 1 time
		/// 4 → 1 time
		/// 8 → 1 time
		///
		///
		/// Diagram:
		///
		/// Input
		/// ↓
		/// Frequency Array
		/// ↓
		/// Rebuild Sorted Array
		/// ↓
		/// Output Sorted
		///
		///
		/// Advantage:
		/// - Very fast O(n + k)
		/// - Good for small integer ranges
		///
		///
		/// Do NOT use:
		/// - Large value ranges (memory heavy)
		/// - Non-integer data
		///
		/// </summary>

		#endregion
	}
}
