using System;
using Algorithms.Utilities;

namespace Algorithms.MinimumDepthInBinaryTree
{
    public class MinDepthInBinaryTree
    {
        public int FindMinDepth(TreeNode<int> root)
        {
            if (root == null)
                return 0;

            var minLeftDepth = FindMinDepth(root.LeftChild);
            var minRightDepth = FindMinDepth(root.RightChild);

            if (minLeftDepth == 0 && minRightDepth == 0)
                return 1;
            else if (minLeftDepth == 0)
                return minRightDepth + 1;
            else if (minRightDepth == 0)
                return minLeftDepth + 1;
            else
                return Math.Min(minLeftDepth, minRightDepth) + 1;
        }
    }
}
