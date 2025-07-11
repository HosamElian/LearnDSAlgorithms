using LearnDSAlgorithms.Heap;

namespace LearnDSAlgorithms.SortAlgorithms
{
    public class HeapSort
    {
        public int[] Sort(int[] arr)
        {
            var heap = new Heap<int>(arr.Length);
            foreach (int item in arr)
            {
                heap.Insert(item);
            }
            var k = heap.Length() - 1;
            for (int i = 0; i < heap.Length(); i++)
            {
                arr[k] = heap.DeleteMax();
                k--;
            }
            return arr;
        }
    }
}
