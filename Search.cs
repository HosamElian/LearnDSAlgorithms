namespace LearnDSAlgorithms
{
    internal class Search
    {
        // time complexity o(n)
        public int LinearSearch(int[] arr, int searchItem)
        {
            int sizeOfArray = arr.Length;
            int index = 0;
            while (index < sizeOfArray)
            {
                if (arr[index] == searchItem)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        // time complexity o( log(n) )

        public int BinarySearch(int[] arr, int searchItem)
        {
            int sizeOfArray = arr.Length;
            int L = 0;
            int R = sizeOfArray - 1;
            int mid = (R + L) / 2;
            while (L < R)
            {
                if (arr[mid] == searchItem)
                    return mid;
                else if (arr[mid] > searchItem)
                    R = mid - 1;
                else if (arr[mid] < searchItem)
                    L = mid + 1;
            }
            return -1;
        }
    }
}
