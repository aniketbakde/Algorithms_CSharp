using System;
using Algorithms.Utilities;

namespace Algorithms.MaximumPathSumInBinaryTree
{
    public class MaxPathSumInBinaryTree
    {
        public int FindMaxSum(TreeNode<int> root, ref int res)
        {
            if (root == null)
                return 0;

            var leftSum = FindMaxSum(root.LeftChild, ref res);
            var rightSum = FindMaxSum(root.RightChild, ref res);

            var maxCurrent = Math.Max(Math.Max(leftSum, rightSum) + root.Value, root.Value);

            var maxBranch = Math.Max(maxCurrent, leftSum + rightSum + root.Value);

            res = Math.Max(res, maxBranch);

            return maxCurrent;
        }
    }
}
