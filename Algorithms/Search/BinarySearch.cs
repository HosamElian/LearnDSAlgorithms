namespace LearnDSAlgorithms.Algorithms.Search
{
	public class BinarySearch
	{
		// time complexity O(log n) || space complexity O(1)

		public int Search(int[] arr, int searchItem)
		{
			int L = 0;

			int R = arr.Length - 1;

			while (L <= R)
			{
				int mid = (L + R) / 2;

				if (arr[mid] == searchItem)
					return mid;

				else if (arr[mid] > searchItem)
					R = mid - 1;

				else
					L = mid + 1;
			}

			return -1;
		}

		#region Explanation

		/// <summary>
		/// Algorithm Analysis:
		///
		/// Time Complexity (Worst Case):
		/// O(log n)
		///
		/// Where:
		/// Each step divides the array into half
		///
		/// Equation:
		/// n / 2^k = 1 → k = log n
		///
		/// Remove Constants:
		/// O(log n)
		///
		///
		/// Space Complexity:
		/// O(1)
		///
		/// Where:
		/// Uses only fixed variables:
		/// - L
		/// - R
		/// - mid
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
		/// [1, 3, 5, 7, 9], search = 7
		///
		/// Steps:
		/// mid = 5 → move right
		/// mid = 7 → found
		///
		///
		/// Note:
		/// Array must be sorted
		///
		/// </summary>

		#endregion
	}
}
