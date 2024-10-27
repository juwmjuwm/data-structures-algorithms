namespace dsa.structures
{
    internal class LinkedList<T>
    {
        private Node<T>? Head { get; set; }
        private Node<T>? Tail { get; set; }
        private int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void AddFirst(T value)
        {
            if (AddIfEmpty(value)) return;
            Node<T> node = new Node<T>(value);
            Head.Prev = node;
            node.Next = Head;
            Head = node;
            Count++;
        }

        public void AddLast(T value)
        {
            if (AddIfEmpty(value)) return;
            Node<T> node = new Node<T>(value);
            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
            Count++;
        }

        private bool AddIfEmpty(T value)
        {
            if (this.IsEmpty())
            {
                Node<T> node = new Node<T>(value);
                Head = node;
                Tail = node;
                Count++;
                return true;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (this.IsEmpty()) return;
            if (RemoveIfSingle()) return;
            Head = Head.Next;
            Head.Prev = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (this.IsEmpty()) return;
            if (RemoveIfSingle()) return;
            Tail = Tail.Prev;
            Tail.Next = null;
            Count--;
        }

        private bool RemoveIfSingle()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
                Count = 0;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return "[]";
            }
            string str = "[";
            Node<T>? cur = Head;
            while (cur != null)
            {
                str = String.Concat(str, ", ", cur.Data);
                cur = cur.Next;
            }
            return String.Concat(str, "]");
        }
    }
}
