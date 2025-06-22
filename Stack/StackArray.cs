using System;
using System.Runtime.InteropServices;

namespace LearnDSAlgorithms.Stack
{
    public sealed class StackArray<T>
    {
        private T[] _stack;

        private int top { get; set; } = 0;

        public StackArray(int size)
        {
            _stack = new T[size];
            top = 0;
        }

        public int Length() => top;

        public bool IsEmpty() => top == 0;

        public bool IsFull() => top == _stack.Length;

        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
                return;
            }

            _stack[top++] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }

            return _stack[--top];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }

            return _stack[top - 1];
        }

        public void display()
        {
            for (int i = 0; i < top; i++)
                Console.Write(_stack[i] + "--");
            Console.WriteLine();
        }
    }
}
