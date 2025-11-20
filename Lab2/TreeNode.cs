using System;

namespace Lab2
{
    public  class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> LeftNode { get; set; }
        public TreeNode<T> RightNode { get; set; }

        public TreeNode(T data)
        {
            Data = data;
            LeftNode = null;
            RightNode = null;
        }
    }
}
