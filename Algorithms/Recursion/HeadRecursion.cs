using System;

namespace LearnDSAlgorithms.Algorithms.Recursion
{
	public class HeadRecursion
	{
		// time complexity O(n) || space complexity O(n)

		public void Calculate(int n)
		{
			if (n > 0)
			{
				Calculate(n--);

				int k = n * n;

				Console.WriteLine(k);
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
		/// Process after recursive calls return
		///
		///
		/// Example:
		///
		/// Input:
		/// 3
		///
		/// Execution Order:
		/// Call stack builds first:
		/// 3 → 2 → 1
		///
		/// Then executes:
		/// 1 → 2 → 3
		///
		/// Output:
		/// 1
		/// 4
		/// 9
		///
		/// </summary>

		#endregion
	}
}
