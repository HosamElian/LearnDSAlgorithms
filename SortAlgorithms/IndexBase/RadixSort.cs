using System.Collections.Generic;

namespace LearnDSAlgorithms.SortAlgorithms
{
    public class RadixSort
    {
        // time complexity o(n)
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
}
