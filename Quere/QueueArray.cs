using System;

namespace LearnDSAlgorithms.Quere
{
    public sealed class QueueArray<T>
    {
        private T[] _queue;

        private int _front { get; set; } = 0;
        private int _rear { get; set; } = 0;
        private int _size { get; set; } = 0;

        public QueueArray(int size)
        {
            _queue = new T[size];
            _front = 0;
            _rear = 0;
            _size = 0;
        }

        public int Length() => _size;

        public bool IsEmpty() => _size == 0;

        public bool IsFull() => _size == _queue.Length;

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            _queue[_rear++] = item;
            _size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default;
            }
            --_size;
            return _queue[_front++];
        }

        public T First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default;
            }
            return _queue[_front];
        }
    }
}
