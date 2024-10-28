namespace dsa.structures
{
    internal class TreeNode<T>
    {
        TreeNode<T>? Parent { get; set; }
        TreeNode<T>? LeftChild { get; set; }
        TreeNode<T>? RightChild { get; set; }
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
