namespace dsa.structures
{
    internal class TreeNode<T>
    {
        public TreeNode<T>? Parent { get; set; }
        public TreeNode<T>? LeftChild { get; set; }
        public TreeNode<T>? RightChild { get; set; }
        T Data { get; set; }

        public TreeNode(T data)
        {
            Parent = null;
            LeftChild = null;
            RightChild = null;
            Data = data;
        }
    }
}
