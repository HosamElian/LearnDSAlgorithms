using System;

namespace LearnDSAlgorithms.Algorithms.Recursion
{
	public class TailRecursion
	{
		// time complexity O(n) || space complexity O(n)

		public void Calculate(int n)
		{
			if (n > 0)
			{
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
		/// O(n)
		///
		/// Where:
		/// n recursive calls until base condition
		///
		/// Equation:
		/// n
		///
		/// Remove Constants:
		/// O(n)
		///
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
		/// Simple recursive countdown processing
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
		/// Flow:
		/// 3 → 2 → 1 → 0 (stop)
		///
		/// </summary>

		#endregion
	}
}
