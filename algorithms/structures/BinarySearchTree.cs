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
            TreeNode<T> newNode = new TreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            TreeNode<T> cur = Root;
            while (true)
            {
                if (newNode.Data.CompareTo(cur.Data) < 0)
                {
                    if (cur.LeftChild == null)
                    {
                        cur.LeftChild = newNode;
                        newNode.Parent = cur;
                        return;
                    }
                    cur = cur.LeftChild;
                }
                else
                {
                    if (cur.RightChild == null)
                    {
                        cur.RightChild = newNode;
                        newNode.Parent = cur;
                        return;
                    }
                    cur = cur.RightChild;
                }
            }
        }

        public bool Remove(T value)
        {
            return Remove(value, Root);
        }

        public bool Remove(T value, TreeNode<T>? baseNode)
        {
            if (Root == null)
            {
                return false;
            }
            TreeNode<T>? cur = baseNode;
            while (true)
            {
                if (cur == null)
                {
                    return false;
                }
                else if (value.CompareTo(cur.Data) < 0)
                {
                    cur = cur.LeftChild;
                }
                else if (value.CompareTo(cur.Data) > 0)
                {
                    cur = cur.RightChild;
                }
                else // here, cur is the node to remove
                {
                    break;
                }
            }

            TreeNode<T>? curParent = cur.Parent;

            // option 1: no children
            if (cur.LeftChild == null && cur.RightChild == null)
            {
                if (curParent == null)
                {
                    Root = null;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = null;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = null;
                    }
                }
                cur.LeftChild = cur.RightChild = cur.Parent = null;
            }

            // option 2: has left child
            else if (cur.LeftChild != null && cur.RightChild == null)
            {
                if (curParent == null)
                {
                    Root = cur.LeftChild;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = cur.LeftChild;
                        cur.LeftChild.Parent = curParent;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = cur.LeftChild;
                        cur.LeftChild.Parent = curParent;
                    }
                }
                cur.LeftChild = cur.RightChild = cur.Parent = null;
            }

            // option 3: has right child
            else if (cur.LeftChild == null && cur.RightChild != null)
            {
                if (curParent == null)
                {
                    Root = cur.RightChild;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = cur.RightChild;
                        cur.RightChild.Parent = curParent;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = cur.RightChild;
                        cur.RightChild.Parent = curParent;
                    }
                }
                cur.LeftChild = cur.RightChild = cur.Parent = null;
            }

            // option 4: has two children
            else
            {
                TreeNode<T> leftmost = cur.RightChild;
                while (leftmost.LeftChild != null)
                {
                    leftmost = leftmost.LeftChild;
                }

                cur.Data = leftmost.Data;
                TreeNode<T> leftmostParent = leftmost.Parent;
                if (leftmost.Data.CompareTo(leftmostParent.Data) < 0)
                {
                    leftmostParent.LeftChild = leftmost.RightChild;
                }
                else
                {
                    leftmostParent.RightChild = leftmost.RightChild;
                }
                if (leftmost.RightChild != null)
                {
                    leftmost.RightChild.Parent = leftmostParent;
                }
                leftmost.LeftChild = leftmost.RightChild = leftmost.Parent = null;

                if (curParent == null)
                {
                    Root = cur;
                }
            }

            if (Root != null)
            {
                Root.Parent = null;
            }
            return true;
        }

        public bool Remove2(T value)
        {
            if (Root == null)
            {
                return false;
            }
            TreeNode<T>? cur = Root;
            while (true)
            {
                if (cur == null)
                {
                    return false;
                }
                else if (value.CompareTo(cur.Data) < 0)
                {
                    cur = cur.LeftChild;
                }
                else if (value.CompareTo(cur.Data) > 0)
                {
                    cur = cur.RightChild;
                }
                else // here, cur is the node to remove
                {
                    break;
                }
            }

            TreeNode<T>? curParent = cur.Parent;

            // option 0
            if (cur.RightChild == null && cur.LeftChild == null)
            {
                if (curParent == null)
                {
                    Root = null;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = null;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = null;
                    }
                }
            }

            // option 1
            else if (cur.RightChild == null)
            {
                if (curParent == null)
                {
                    Root = cur.LeftChild;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = cur.LeftChild;
                        cur.LeftChild.Parent = curParent;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = cur.LeftChild;
                        cur.LeftChild.Parent = curParent;
                    }
                }
            }

            // option 2
            else if (cur.RightChild.LeftChild == null)
            {
                cur.RightChild.LeftChild = cur.LeftChild;
                if (cur.LeftChild != null)
                {
                    cur.LeftChild.Parent = cur.RightChild;
                }
                if (curParent == null)
                {
                    Root = cur.RightChild;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = cur.RightChild;
                        cur.RightChild.Parent = curParent;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = cur.RightChild;
                        cur.RightChild.Parent = curParent;
                    }
                }
            }

            // option 3
            else
            {
                TreeNode<T> leftmost = cur.RightChild.LeftChild;
                while (leftmost.LeftChild != null)
                {
                    leftmost = leftmost.LeftChild;
                }
                TreeNode<T> leftmostParent = leftmost.Parent;

                leftmostParent.LeftChild = leftmost.RightChild;
                if (leftmost.RightChild != null)
                {
                    leftmost.RightChild.Parent = leftmostParent;
                }
                leftmost.LeftChild = cur.LeftChild;
                if (cur.LeftChild != null)
                {
                    cur.LeftChild.Parent = leftmost;
                }
                leftmost.RightChild = cur.RightChild;
                cur.RightChild.Parent= leftmost;
                if (curParent == null)
                {
                    Root = leftmost;
                }
                else
                {
                    if (cur.Data.CompareTo(curParent.Data) < 0)
                    {
                        curParent.LeftChild = leftmost;
                    }
                    else if (cur.Data.CompareTo(curParent.Data) > 0)
                    {
                        curParent.RightChild = leftmost;
                    }
                    leftmost.Parent = curParent;
                }
            }

            // cleanup
            cur.LeftChild = null;
            cur.RightChild = null;
            cur.Parent = null;
            if (Root != null)
            {
                Root.Parent = null;
            }
            return true;
        }

        public List<T> DfsInOrder()
        {
            return TraverseInOrder(Root, new List<T>());
        }

        private List<T> TraverseInOrder(TreeNode<T> node,  List<T> list)
        {
            if (node == null)
            {
                return list;
            }
            TraverseInOrder(node.LeftChild, list);
            list.Add(node.Data);
            TraverseInOrder(node.RightChild, list);
            return list;
        }

        public List<T> DfsPreOrder()
        {
            return TraversePreOrder(Root, new List<T>());
        }

        private List<T> TraversePreOrder(TreeNode<T> node, List<T> list)
        {
            if (node == null)
            {
                return list;
            }
            list.Add(node.Data);
            TraversePreOrder(node.LeftChild, list);
            TraversePreOrder(node.RightChild, list);
            return list;
        }

        public List<T> DfsPostOrder()
        {
            return TraversePostOrder(Root, new List<T>());
        }

        private List<T> TraversePostOrder(TreeNode<T> node, List<T> list)
        {
            if (node == null)
            {
                return list;
            }
            TraversePostOrder(node.LeftChild, list);
            TraversePostOrder(node.RightChild, list);
            list.Add(node.Data);
            return list;
        }
    }
}
