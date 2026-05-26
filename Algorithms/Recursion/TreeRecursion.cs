using System;

namespace LearnDSAlgorithms.Algorithms.Recursion
{
	internal class TreeRecursion
	{
		// time complexity O(2^n) || space complexity O(n)

		public void Calculate(int n)
		{
			if (n > 0)
			{
				Calculate(n--);

				int k = n * n;

				Console.WriteLine(k);

				Calculate(n--);
			}
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(2^n)
		///
		/// Space Complexity:
		/// O(n)
		///
		///
		/// Stable:
		/// N/A
		///
		/// In Place:
		/// No
		///
		///
		/// Used:
		/// Multiple recursive branches per call
		///
		///
		/// Example:
		///
		/// Input:
		/// 2
		///
		/// Call tree:
		///        2
		///      /   \
		///     1     1
		///    / \   / \
		///
		/// Output grows exponentially
		///
		/// </summary>

		#endregion
	}
}
