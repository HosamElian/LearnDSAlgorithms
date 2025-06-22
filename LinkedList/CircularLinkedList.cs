using System;

namespace LearnDSAlgorithms.LinkedList
{
    public sealed class CircularLinkedList<T>
    {
        private int Size = 0;
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public bool IsEmpty() => (Size <= 0);

        public int Count() => Size;

        public CircularLinkedList()
        {
            Size = 0;
            Head = null;
            Tail = null;
        }

        public void InsertAtBegging(T item)
        {
            Node<T> newset = new Node<T>(item, null);
            if (IsEmpty())
            {
                newset.Next = newset;
                Head = newset;
                Tail = newset;
            }
            else
            {
                newset.Next = Head;
                Head = newset;
                Tail.Next = newset;
            }
            Size++;
        }

        public void InsertAtEnd(T item)
        {
            Node<T> newset = new Node<T>(item, null);
            if (IsEmpty())
            {
                Head = newset;
                newset.Next = newset;
            }
            else
            {
                newset.Next = Tail.Next;
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
            Tail.Next = Head;
            Size--;
            return p.Value;
        }

        public T DeleteFromEnd()
        {
            if (IsEmpty())
                return default;

            if (Size == 1)
            {
                var lastElement = Head.Value;
                Clear();
                return lastElement;
            }

            var p = Head;
            int i = 0;
            while (i < Size - 1)
            {
                p = p.Next;
                i++;
            }
            p.Next = Head;
            Tail = p;
            Size--;

            return p.Value;
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
            T removedElement = p.Next.Value;
            p.Next = p.Next.Next;
            Size--;
            return removedElement;
        }

        public int Search(T itme)
        {
            if (IsEmpty())
            {
                return -1;
            }
            int index = 0;
            var p = Head;
            while (index < Size)
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
            Size = 0;
            Head = null;
            Tail = null;
        }

        public void Display()
        {
            var p = Head;
            int i = 0;
            while (i < Size)
            {
                if (p.Value != null)
                {
                    Console.Write($"{p.Value} --> ");
                }
                p = p.Next;
                i++;
            }
            Console.WriteLine();
        }
    }
}
