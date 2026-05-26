using System.Collections.Generic;

namespace LearnDSAlgorithms.Algorithms.Sort
{
	public class RadixSort : ISort
	{
		// time complexity O(n * k) || stable || Not In Place
		// space Complexity: O(n + k)

		public int[] Sort(int[] arr)
		{
			int arrSize = arr.Length;
			if (arrSize == 0)
				return new int[0];
			int max = GetMax(arr);
			for (int exp = 1; max / exp > 0; exp *= 10)
			{
				List<int>[] bins = new List<int>[10];
				for (int i = 0; i < 10; i++)
					bins[i] = new List<int>();
				for (int i = 0; i < arrSize; i++)
				{
					int digit = (arr[i] / exp) % 10;
					bins[digit].Add(arr[i]);
				}
				int index = 0;
				for (int i = 0; i < 10; i++)
				{
					foreach (int num in bins[i])
					{
						arr[index++] = num;
					}
				}
			}
			return arr;
		}

		private int GetDigitsNumber(int max)
		{
			return max.ToString().Length;
		}

		private int GetMax(int[] array)
		{
			int max = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > max)
				{
					max = array[i];
				}
			}
			return max;
		}
	}

	#region Explanation

	/// <summary>
	/// Algorithm Analysis:
	///
	/// Time Complexity (Worst Case):
	/// O(n * k)
	///
	/// Where:
	/// n → number of elements
	/// k → number of digits in max number
	///
	/// Derivation:
	///
	/// Each digit pass processes all elements:
	/// O(n)
	///
	/// Number of passes:
	/// O(k)
	///
	/// Equation:
	/// O(n × k)
	///
	/// Remove Constants:
	/// O(n × k)
	///
	///
	/// Space Complexity:
	/// O(n + k)
	///
	/// Where:
	/// Uses:
	/// - bins[10] buckets
	/// - temporary lists for distribution
	///
	/// Memory grows with input size and digit groups.
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
	/// Sort integers digit by digit
	/// from least significant to most significant.
	///
	///
	/// Problem:
	///
	/// Comparison sorting becomes slow
	/// for large integer datasets.
	///
	///
	/// Solution:
	///
	/// Use digit-based grouping:
	///
	/// 1. Sort by units digit
	/// 2. Sort by tens digit
	/// 3. Sort by hundreds digit
	/// 4. Repeat until max digit
	///
	///
	/// Example:
	///
	/// [170, 45, 75, 90, 802]
	///
	/// Pass 1 (units):
	/// [170, 90, 802, 45, 75]
	///
	/// Pass 2 (tens):
	/// [802, 45, 75, 170, 90]
	///
	/// Pass 3 (hundreds):
	/// [45, 75, 90, 170, 802]
	///
	///
	/// Diagram:
	///
	/// Input
	/// ↓
	/// Group by digit
	/// ↓
	/// Rebuild array
	/// ↓
	/// Repeat
	/// ↓
	/// Sorted
	///
	///
	/// Advantage:
	/// - Very fast for fixed digit numbers
	/// - Stable sorting
	///
	///
	/// Do NOT use:
	/// - Floating point numbers
	/// - Negative numbers (without modification)
	///
	/// </summary>

	#endregion
}
