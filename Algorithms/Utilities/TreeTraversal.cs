using System;
using System.Diagnostics;

namespace Algorithms.Utilities
{
    public class TreeTraversal<T>
    {
        public void PreOrder(TreeNode<T> root)
        {
            if(root == null)
                return;

            Console.Write("{0}, ", root.Value.ToString());
            PreOrder(root.LeftChild);
            PreOrder(root.RightChild);
        }

        public void InOrder(TreeNode<T> root)
        {
            if (root == null)
                return;

            InOrder(root.LeftChild);
            Console.Write("{0}, ", root.Value.ToString());
            InOrder(root.RightChild);
        }

        public void PostOrder(TreeNode<T> root)
        {
            if (root == null)
                return;

            PostOrder(root.LeftChild);
            PostOrder(root.RightChild);
            Console.Write("{0}, ", root.Value.ToString());
        }
    }
}
