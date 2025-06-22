using System;

namespace LearnDSAlgorithms.Quere
{
    public sealed class QueueLinkedList<T>
        where T : IComparable<T>
    {
        private LinearLinkedList<T> _queue;

        public QueueLinkedList()
        {
            _queue = new LinearLinkedList<T>();
        }

        public int Length() => _queue.Count();

        public bool IsEmpty() => _queue.IsEmpty();

        public void Enqueue(T item)
        {
            _queue.InsertAtEnd(item);
        }

        public T Dequeue()
        {
            return _queue.DeleteFromBegging();
        }

        public T First()
        {
            return _queue.Head.Value;
        }
    }
}
