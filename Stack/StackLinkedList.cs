using System;

namespace LearnDSAlgorithms.Stack
{
    public sealed class StackLinkedList<T>
        where T : IComparable<T>
    {
        private LinearLinkedList<T> _stack;

        public StackLinkedList()
        {
            _stack = new LinearLinkedList<T>();
        }

        public int Length() => _stack.Count();

        public bool IsEmpty() => _stack.IsEmpty();

        public void Push(T item)
        {
            _stack.InsertAtBegging(item);
        }

        public T Pop()
        {
            return _stack.DeleteFromBegging();
        }

        public T Peek()
        {
            return _stack.Head.Value;
        }
    }
}
