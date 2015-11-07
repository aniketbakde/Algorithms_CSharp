using System;
using System.Diagnostics;
using Algorithms.MaximumPathSumInBinaryTree;
using Algorithms.MinimumDepthInBinaryTree;
using Algorithms.Utilities;

namespace Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Driver().Drive();
        }
    }

    public class Driver
    {
        public void Drive()
        {
            //DriveMaximumPathSumInBinaryTree();
            DriveMinimumDepthInBinaryTree();
        }

        private void DriveMaximumPathSumInBinaryTree()
        {
            var classRef = new MaxPathSumInBinaryTree();
            var treeBuilder = new TreeBuilder();

            var root = treeBuilder.BootStrapTree1();
            var res = 0;
            classRef.FindMaxSum(root, ref res);
            Debug.WriteLine(String.Format("Max sum of one of the branch is : {0}", res));

            root = treeBuilder.BootStrapTree2();
            res = 0;
            classRef.FindMaxSum(root, ref res);
            Debug.WriteLine(String.Format("Max sum of one of the branch is : {0}", res));

            root = treeBuilder.BootStrapTree3();
            res = 0;
            classRef.FindMaxSum(root, ref res);
            Debug.WriteLine(String.Format("Max sum of one of the branch is : {0}", res));
        }

        private void DriveMinimumDepthInBinaryTree()
        {
            var classRef = new MinDepthInBinaryTree();
            var treeBuilder = new TreeBuilder();

            var root = treeBuilder.BootStrapTree4();
            var minDepth = classRef.FindMinDepth(root);
            Debug.WriteLine(String.Format("Min depth of tree is : {0}", minDepth));

            root = treeBuilder.BootStrapTree2();
            minDepth = classRef.FindMinDepth(root);
            Debug.WriteLine(String.Format("Min depth of tree is : {0}", minDepth));

            root = treeBuilder.BootStrapTree1();
            minDepth = classRef.FindMinDepth(root);
            Debug.WriteLine(String.Format("Min depth of tree is : {0}", minDepth));
        }
    }
}
