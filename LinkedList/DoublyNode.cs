namespace LearnDSAlgorithms.LinkedList
{
    public sealed class DoublyNode<T>
    {
        public DoublyNode(T value, DoublyNode<T> next, DoublyNode<T> previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public T Value { get; set; }
        public DoublyNode<T> Next { get; set; }
        public DoublyNode<T> Previous { get; set; }
    }
}
