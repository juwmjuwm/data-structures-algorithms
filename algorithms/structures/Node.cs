using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.structures
{
    internal class Node<T>
    {

        public Node<T> Next;
        public Node<T> Prev;
        public T Data;
    }
}
