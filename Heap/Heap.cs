using System;

namespace LearnDSAlgorithms.Heap
{
    //Max heap
    // if need to make it min heap make the root smallest value
    public class Heap<T>
         where T : IComparable<T>
    {
        private int CSize = 0;
        private int MaxSize = 10;
        private T[] _data = null;
        public Heap(int maxSize = 10)
        {
            MaxSize = maxSize;
            _data = new T[MaxSize];
        }
        public int Length() => CSize;
        public bool IsEmpty() => CSize == 0;
        //time complexity O(log n)
        public void Insert(T item)
        {
            int hi = 0;
            if (CSize == MaxSize)
            {
                Console.WriteLine("No Space available");
            }
            CSize++;
            hi = CSize;
            while (hi > 1 && item.CompareTo(_data[hi / 2]) > 0)
            {
                _data[hi] = _data[hi / 2];
                hi = hi / 2;
            }
            _data[hi] = item;
        }
        //time complexity O( log n)
        public T DeleteMax()
        {
            T oldRoot = _data[1];
            _data[1] = _data[CSize];
            _data[CSize] = default;
            CSize--;
            int parentIndex = 1;
            int childIndex = parentIndex * 2;
            while (childIndex <= CSize)
            {
                if (_data[childIndex].CompareTo(_data[childIndex + 1]) < 0)
                {
                    childIndex++;
                }
                if (_data[parentIndex].CompareTo(_data[childIndex]) < 0)
                {
                    T temp = _data[parentIndex];
                    _data[parentIndex] = _data[childIndex];
                    _data[childIndex] = temp;
                    parentIndex = childIndex;
                    childIndex = parentIndex * 2;
                }
                else
                {
                    break;
                }
            }
            return oldRoot;
            //time complexity O(n log n)
        }
        public T Max()
        {
            if (IsEmpty())
                return default;

            return _data[CSize];
        }
        public void Clear()
        {
            _data = new T[MaxSize];
            CSize = 0;
        }
        public void Display()
        {
            for (int i = 0; i < _data.Length; i++)
                Console.WriteLine($"{_data[i]} ");
            Console.WriteLine();
        }
    }
}
