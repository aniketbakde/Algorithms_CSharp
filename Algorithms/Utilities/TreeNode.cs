
namespace Algorithms.Utilities
{
    public class TreeNode<T>
    {
        public T Value;
        public TreeNode<T> LeftChild;
        public TreeNode<T> RightChild;

        public TreeNode()
        {
            LeftChild = null;
            RightChild = null;
        } 
    }
}
