namespace dsa.structures
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public TreeNode<T>? Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new TreeNode<T>(value);
                return;
            }
            TreeNode<T> newNode = new TreeNode<T>(value);
            TreeNode<T> cur = Root;
            while (value.CompareTo(cur.Data) <= 0 && cur.LeftChild != null ||
                value.CompareTo(cur.Data) > 0 && cur.RightChild != null)
            {
                if (value.CompareTo(cur.Data) <= 0)
                {
                    cur = cur.LeftChild;
                } else
                {
                    cur = cur.RightChild;
                }
            }
            if (value.CompareTo(cur.Data) <= 0)
            {
                cur.LeftChild = newNode;
            }
            else
            {
                cur.RightChild = newNode;
            }
        }
    }
}
