using System;

namespace LearnDSAlgorithms
{
    public sealed class LinearLinkedList<T>
        where T : IComparable<T>
    {
        private int Size = 0;
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public bool IsEmpty() => (Size <= 0);

        public int Count() => Size;

        public LinearLinkedList()
        {
            Size = 0;
            Head = null;
            Tail = null;
        }

        public void InsertSorted(T item)
        {
            var newset = new Node<T>(item, null);
            if (IsEmpty())
            {
                Head = newset;
                Tail = newset;
            }
            else
            {
                var p = Head;
                var prev = Head;
                while (p != null && IsNewItemSmaller(newset, p))
                {
                    prev = p;
                    p = p.Next;
                }
                if (p == Head)
                {
                    newset.Next = Head.Next;
                    Head = newset;
                }
                else
                {
                    newset.Next = prev.Next;
                    prev.Next = newset;
                }
            }

            Size++;
        }

        private static bool IsNewItemSmaller(Node<T> newset, Node<T> p)
        {
            return newset.Value.CompareTo(p.Value) < 0;
        }

        public void InsertAtBegging(T item)
        {
            Node<T> newset = new Node<T>(item, null);
            if (IsEmpty())
            {
                Head = newset;
                Tail = newset;
            }
            else
            {
                newset.Next = Head;
                Head = newset;
            }
            Size++;
        }

        public void InsertAtEnd(T item)
        {
            Node<T> newset = new Node<T>(item, null);
            if (IsEmpty())
            {
                Head = newset;
            }
            else
            {
                Tail.Next = newset;
            }
            Tail = newset;
            Size++;
        }

        public void InsertAtPosition(T item, int position)
        {
            if (position > Size || position < 0)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if (position == 0)
            {
                InsertAtBegging(item);
                return;
            }
            if (position == Size)
            {
                InsertAtEnd(item);
                return;
            }
            var newset = new Node<T>(item, null);
            var p = Head;
            int elementIndex = 1;
            while (elementIndex < position)
            {
                p = p.Next;
                elementIndex++;
            }

            newset.Next = p.Next;
            p.Next = newset;
            Size++;
        }

        public T DeleteFromBegging()
        {
            if (IsEmpty())
            {
                return default;
            }
            if (Size == 1)
            {
                var lastElement = Head.Value;
                Clear();
                return lastElement;
            }

            var p = Head;
            Head = p.Next;
            Size--;
            return p.Value;
        }

        public T DeleteFromEnd()
        {
            if (IsEmpty())
            {
                return default;
            }
            if (Size == 1)
            {
                var lastElement = Head.Value;
                Clear();
                return lastElement;
            }

            var p = Head;
            int i = 1;
            while (i < Size - 1)
            {
                p = p.Next;
                i++;
            }
            var lastValue = Tail.Value;
            Tail = p;
            Tail.Next = null;
            Size--;
            return lastValue;
        }

        public T DeleteFromPosition(int position)
        {
            if (IsEmpty())
            {
                return default;
            }

            if (position == 0)
            {
                return DeleteFromBegging();
            }

            if (position < 0 || position > Size)
            {
                Console.WriteLine("Out Of range");
                return default;
            }

            if (position == Size)
            {
                return DeleteFromEnd();
            }

            var p = Head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.Next;
                i++;
            }
            p.Next = p.Next.Next;
            Size--;
            return p.Next.Value;
        }

        public int Search(T itme)
        {
            if (IsEmpty())
            {
                return -1;
            }
            int index = 0;
            var p = Head;
            while (p != null)
            {
                if (p.Value.Equals(itme))
                {
                    return index;
                }
                index++;
                p = p.Next;
            }
            return -1;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public void Display()
        {
            var p = Head;
            while (p != null)
            {
                if (p.Value != null)
                {
                    Console.Write($"{p.Value} --> ");
                }
                p = p.Next;
            }
            Console.WriteLine();
        }
    }
}
