using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.structures
{
    internal class LinkedList<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        private int Count { get; set; }


        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            this.Tail.Next = node;
            node.Prev = this.Tail;
            this.Count++;
        }
    }
}
