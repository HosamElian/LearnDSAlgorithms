using System;

namespace LearnDSAlgorithms.Quere
{
    public sealed class DoubleQueueLinkedList<T>
        where T : IComparable<T>
    {
        private LinearLinkedList<T> _queue;

        public DoubleQueueLinkedList()
        {
            _queue = new LinearLinkedList<T>();
        }

        public int Length() => _queue.Count();

        public bool IsEmpty() => _queue.IsEmpty();

        public void AddFirst(T item)
        {
            _queue.InsertAtBegging(item);
        }

        public void AddLast(T item)
        {
            _queue.InsertAtEnd(item);
        }

        public void Clear() { }

        public T RemoveFirst()
        {
            return _queue.DeleteFromBegging();
        }

        public T RemoveLast()
        {
            return _queue.DeleteFromEnd();
        }

        public T First()
        {
            return _queue.Head.Value;
        }

        public T Last()
        {
            return _queue.Tail.Value;
        }
    }
}
