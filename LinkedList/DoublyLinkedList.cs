using System;

namespace LearnDSAlgorithms.LinkedList
{
    public sealed class DoublyLinkedList<T>
    {
        private int Size = 0;
        public DoublyNode<T> Head { get; set; }
        public DoublyNode<T> Tail { get; set; }

        public bool IsEmpty() => (Size <= 0);

        public int Count() => Size;

        public DoublyLinkedList()
        {
            Size = 0;
            Head = null;
            Tail = null;
        }

        public void InsertAtBegging(T item)
        {
            var newset = new DoublyNode<T>(item, null, null);
            if (IsEmpty())
            {
                Head = newset;
                Tail = newset;
            }
            else
            {
                newset.Next = Head;
                Head.Previous = newset;
                Head = newset;
            }
            Size++;
        }

        public void InsertAtEnd(T item)
        {
            var newset = new DoublyNode<T>(item, null, null);
            if (IsEmpty())
            {
                Head = newset;
            }
            else
            {
                Tail.Next = newset;
                newset.Previous = Tail;
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
            var newset = new DoublyNode<T>(item, null, null);

            var p = Head;
            int elementIndex = 1;
            while (elementIndex < position)
            {
                p = p.Next;
                elementIndex++;
            }

            p.Next.Previous = newset;
            newset.Next = p.Next;
            newset.Previous = p;
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
            Head.Previous = null;
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
            var p = Tail;
            Tail = p.Previous;
            Tail.Next = null;
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
            while (i < position)
            {
                p = p.Next;
                i++;
            }
            T removedElement = p.Next.Value;
            p.Next = p.Next.Next;
            p.Next.Next.Previous = p;
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

        public void Clear()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }
    }
}
