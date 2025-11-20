using System.Collections;

namespace Lab2
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private TreeNode<T> root;
        private IComparer<T> comparer;

        public BinaryTree(IComparer<T>? comparer = null)
        {
            this.comparer = comparer ?? Comparer<T>.Default;
        }
        public void Add(T value)
        {
            root = AddRecursive(root, value);
        }
        private TreeNode<T> AddRecursive(TreeNode<T>? node, T value)
        {
            if (node == null)
            {
                return new TreeNode<T>(value);
            }
            int cmp = comparer.Compare(value, node.Data);
            if (cmp < 0)
            {
                node.LeftNode = AddRecursive(node.LeftNode, value);
            }
            else if (cmp > 0)
            {
                node.RightNode = AddRecursive(node.RightNode, value);
            }
            return node;
        }
        public IEnumerable<T> PreOrder()
        {
            if (root == null)
                yield break;
            var stack = new Stack<TreeNode<T>>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                yield return node.Data;
                if (node.RightNode != null)
                    stack.Push(node.RightNode);
                if (node.LeftNode != null)
                    stack.Push(node.LeftNode);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return PreOrder().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void Print(TreeNode<T> node)
        {
            if (node == null) return;
            Console.WriteLine(node.Data);
            Print(node.LeftNode);
            Print(node.RightNode);
        }
        public void Print() { Print(root); }
    }
}
