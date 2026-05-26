using System;

namespace LearnDSAlgorithms.Algorithms.Recursion
{
	public class IndirectRecursion
	{
		// time complexity O(n) || space complexity O(n)

		public void CalculateA(int n)
		{
			if (n > 0)
			{
				CalculateB(n--);

				int k = n * n;

				Console.WriteLine(k);
			}
		}

		public void CalculateB(int n)
		{
			if (n > 0)
			{
				CalculateA(n--);

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
		/// Functions calling each other
		///
		///
		/// Example:
		///
		/// Input:
		/// 3
		///
		/// Flow:
		/// A(3) → B(2) → A(1) → B(0 stop)
		///
		/// Output:
		/// sequence of alternating calls
		///
		/// </summary>

		#endregion
	}
}
