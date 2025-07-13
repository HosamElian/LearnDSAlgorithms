namespace LearnDSAlgorithms.SortAlgorithms
{
    public class CountSort
    {
        //time complexity O(n)
        // space complexity O (n)
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return arr;

            int i = 0, j = 0;

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
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
