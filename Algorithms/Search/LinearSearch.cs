namespace LearnDSAlgorithms.Algorithms.Search
{
	public class LinearSearch
	{
		// time complexity O(n) || space complexity O(1)

		public int Search(int[] arr, int searchItem)
		{
			int sizeOfArray = arr.Length;

			int index = 0;

			while (index < sizeOfArray)
			{
				if (arr[index] == searchItem)
					return index;

				index++;
			}

			return -1;
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(n)
		///
		/// Where:
		/// We scan each element once in worst case
		///
		/// Equation:
		/// n
		///
		/// Remove Constants:
		/// O(n)
		///
		///
		/// Space Complexity:
		/// O(1)
		///
		/// Where:
		/// Uses only fixed variables:
		/// - index
		/// - sizeOfArray
		///
		///
		/// Stable:
		/// N/A
		///
		/// In Place:
		/// Yes
		///
		///
		/// Example:
		///
		/// Input:
		/// [5, 2, 9, 1], search = 9
		///
		/// Steps:
		/// 5 → 2 → 9 (found)
		///
		/// </summary>

		#endregion
	}
}
