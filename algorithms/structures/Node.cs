namespace dsa.structures
{
    internal class Node<T>
    {

        public Node<T>? Next { get; set; }
        public Node<T>? Prev { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
