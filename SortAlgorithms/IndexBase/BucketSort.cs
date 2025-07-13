using System.Collections.Generic;

namespace LearnDSAlgorithms.SortAlgorithms
{
    public class BucketSort
    {
        // time complexity o(n^2)
        public int[] Sort(int[] arr)
        {

            int max = GetMax(arr);
            int arrSize = arr.Length;
            if (arrSize == 0) return new int[0];

            List<int>[] buckets = new List<int>[arrSize];
            for (int i = 0; i < arrSize; i++)
                buckets[i] = new List<int>();

            for (int i = 0; i < arrSize; i++)
            {
                int bucketIndex = arrSize * arr[i] / (max + 1); 
                buckets[bucketIndex].Add(arr[i]);
            }
            for (int i = 0; i < arrSize; i++)
            {
                buckets[i].Sort();
            }
            int index = 0;
            for (int i = 0; i < arrSize; i++)
            {
                foreach (int num in buckets[i])
                {
                    arr[index++] = num;
                }
            }
            return arr;
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
}
