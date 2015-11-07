using Algorithms.Utilities;

namespace Algorithms.RemoveHalfNodes
{
    public class RemHalfNodes<T>
    {
        public TreeNode<T> RemoveNodes(ref TreeNode<T> root)
        {
            if (root == null)
                return null;

            var hasLeftChild = (root.LeftChild != null);
            var hasRightChild = (root.RightChild != null);

            if (hasLeftChild ^ hasRightChild)
            {
                if (hasLeftChild)
                {
                    root = root.LeftChild;
                }
                else
                {
                    root = root.RightChild;
                }
                RemoveNodes(ref root);
            }
            else
            {
                RemoveNodes(ref root.LeftChild);
                RemoveNodes(ref root.RightChild);
            }

            return root;
        }
    }
}
