using System;

namespace LearnDSAlgorithms
{
    internal class Sort
    {
        // time complexity O(n^2) || unstable
        // space Complexity: O (1)
        public int[] SelectionSort(int[] arr)
        {
            int arraySize = arr.Length;
            for (int i = 0; i < arraySize; i++)
            {
                int lowestValueIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[lowestValueIndex])
                        lowestValueIndex = j;
                }
                int temp = arr[i];
                arr[i] = arr[lowestValueIndex];
                arr[lowestValueIndex] = temp;
            }
            return arr;
        }

        // time complexity O(n^2) || stable
        // space Complexity: O (1)
        public int[] InsertionSort(int[] arr)
        {
            int arraySize = arr.Length;

            for (int i = 1; i < arraySize; i++)
            {
                int currentValue = arr[i];
                int position = i;

                while (position > 0 && arr[position - 1] > currentValue)
                {
                    arr[position] = arr[position - 1];
                    position--;
                }
                arr[position] = currentValue;
            }

            return arr;
        }

        // time complexity O(n^2) || stable
        // space Complexity: O (1)
        public int[] BubbleSort(int[] arr)
        {
            int arraySize = arr.Length;
            for (int i = arraySize - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        // time complexity o(n Log(n)) || unstable
        // space Complexity: O (1)
        public int[] ShellSort(int[] arr)
        {
            int arraySize = arr.Length;
            for (int gap = arraySize / 2; gap > 0; gap = gap / 2)
            {
                for (int i = gap; i < arraySize; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && temp < arr[j - gap]; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
            return arr;
        }

        // time complexity O(n log n)  || stable
        // space Complexity: O (n)
        public int[] MergeSort(int[] arr)
        {
            int arraySize = arr.Length;
            if (arraySize <= 1)
                return arr;

            int mid = arraySize / 2;

            int[] left = new int[mid];
            Array.Copy(arr, 0, left, 0, mid);

            int[] right = new int[arraySize - mid];
            Array.Copy(arr, mid, right, 0, arraySize - mid);

            MergeSort(left);
            MergeSort(right);

            return Merge(arr, left, right);
        }

        private int[] Merge(int[] result, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int finalArrayIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                    result[finalArrayIndex++] = left[leftIndex++];
                else
                    result[finalArrayIndex++] = right[rightIndex++];
            }

            while (leftIndex < left.Length)
                result[finalArrayIndex++] = left[leftIndex++];

            while (rightIndex < right.Length)
                result[finalArrayIndex++] = right[rightIndex++];

            return result;
        }

        // time complexity O (n ^2) || unstable
        // space Complexity: O (n)
        public int[] QuickSort(int[] arr)
        {
            return quickSort(arr, 0, arr.Length - 1);
        }

        private int[] quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                quickSort(arr, low, pivotIndex - 1);
                quickSort(arr, pivotIndex + 1, high);
            }
            return arr;
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && arr[i] <= pivot)
                    i++;

                while (i <= j && arr[j] > pivot)
                    j--;

                if (i <= j)
                    Swap(arr, i, j);
            } while (i < j);

            Swap(arr, low, j);
            return j;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
