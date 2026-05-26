using System;

namespace LearnDSAlgorithms.Algorithms.Recursion
{
	public class IterativeRecursion
	{
		// time complexity O(n) || space complexity O(1)

		public void Calculate(int n)
		{
			while (n > 0)
			{
				int k = n * n;

				Console.WriteLine(k);

				--n;
			}
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n)
		///
		/// Space Complexity:
		/// O(1)
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
		/// Iterative replacement of recursion
		///
		///
		/// Example:
		///
		/// Input:
		/// 3
		///
		/// Output:
		/// 9
		/// 4
		/// 1
		///
		/// Loop:
		/// 3 → 2 → 1 → 0
		///
		/// </summary>

		#endregion
	}
}
