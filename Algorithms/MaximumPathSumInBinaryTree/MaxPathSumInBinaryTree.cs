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

        public TreeNode<int> BootStrapTree1()
        {
            return new TreeNode<int>()
            {
                Value = 10,
                LeftChild = new TreeNode<int>()
                {
                    Value = 2,
                    LeftChild = new TreeNode<int>()
                    {
                        Value = 20
                    },
                    RightChild = new TreeNode<int>()
                    {
                        Value = 1
                    }
                },
                RightChild = new TreeNode<int>()
                {
                    Value = 10,
                    RightChild = new TreeNode<int>()
                    {
                        Value = -25,
                        LeftChild = new TreeNode<int>()
                        {
                            Value = 3
                        },
                        RightChild = new TreeNode<int>()
                        {
                            Value = 4
                        }
                    }
                }
            };
        }

        public TreeNode<int> BootStrapTree2()
        {
            return new TreeNode<int>()
            {
                Value = 1,
                LeftChild = new TreeNode<int>()
                {
                    Value = 2
                },
                RightChild = new TreeNode<int>()
                {
                    Value = 3
                }
            };
        }
    }
}
