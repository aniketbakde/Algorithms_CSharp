using System;
using Algorithms.MaximumPathSumInBinaryTree;
using Algorithms.MaxIndexArraySum;
using Algorithms.MinimumDepthInBinaryTree;
using Algorithms.RemoveHalfNodes;
using Algorithms.ReorderArrayForIndex;
using Algorithms.Utilities;

namespace Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Driver().Drive();
            Console.ReadLine();
        }
    }

    public class Driver
    {
        public void Drive()
        {
            //DriveMaximumPathSumInBinaryTree();
            //DriveMinimumDepthInBinaryTree();
            //DriveRemoveHalfNodes();
            //DriveReorderArrayForIndex();
            DriveMaxIndexArrSum();
        }

        private void DriveMaximumPathSumInBinaryTree()
        {
            var classRef = new MaxPathSumInBinaryTree();
            var treeBuilder = new TreeBuilder();

            var root = treeBuilder.BootStrapTree1();
            var res = 0;
            classRef.FindMaxSum(root, ref res);
            Console.WriteLine("Max sum of one of the branch is : {0}", res);

            root = treeBuilder.BootStrapTree2();
            res = 0;
            classRef.FindMaxSum(root, ref res);
            Console.WriteLine("Max sum of one of the branch is : {0}", res);

            root = treeBuilder.BootStrapTree3();
            res = 0;
            classRef.FindMaxSum(root, ref res);
            Console.WriteLine("Max sum of one of the branch is : {0}", res);
        }

        private void DriveMinimumDepthInBinaryTree()
        {
            var classRef = new MinDepthInBinaryTree<int>();
            var treeBuilder = new TreeBuilder();

            var root = treeBuilder.BootStrapTree4();
            var minDepth = classRef.FindMinDepth(root);
            Console.WriteLine("Min depth of tree is : {0}", minDepth);

            root = treeBuilder.BootStrapTree2();
            minDepth = classRef.FindMinDepth(root);
            Console.WriteLine("Min depth of tree is : {0}", minDepth);

            root = treeBuilder.BootStrapTree1();
            minDepth = classRef.FindMinDepth(root);
            Console.WriteLine("Min depth of tree is : {0}", minDepth);
        }

        private void DriveRemoveHalfNodes()
        {
            var classRef = new RemHalfNodes<int>();
            var treeBuilder = new TreeBuilder();
            var treeTraversal = new TreeTraversal<int>();

            var root = treeBuilder.BootStrapTree5();
            var newRoot = classRef.RemoveNodes(ref root);
            treeTraversal.PreOrder(newRoot);
            Console.WriteLine();

            root = treeBuilder.BootStrapTree1();
            newRoot = classRef.RemoveNodes(ref root);
            treeTraversal.PreOrder(newRoot);
            Console.WriteLine();

            root = treeBuilder.BootStrapTree2();
            newRoot = classRef.RemoveNodes(ref root);
            treeTraversal.PreOrder(newRoot);
            Console.WriteLine();

            root = treeBuilder.BootStrapTree3();
            newRoot = classRef.RemoveNodes(ref root);
            treeTraversal.PreOrder(newRoot);
            Console.WriteLine();
        }

        private void DriveReorderArrayForIndex()
        {
            var classRef = new ReorderArrForIndex();

            var array = new int[] {10, 11, 12};
            var index = new int[] {1, 0, 2};
            var n = 3;
            classRef.Reorder(ref array, index, n);
            new PrintArray<int>(array);
            Console.WriteLine();

            array = new int[] { 50, 40, 70, 60, 90 };
            index = new int[] { 3, 0, 4, 1, 2 };
            n = 3;
            classRef.Reorder(ref array, index, n);
            new PrintArray<int>(array);
            Console.WriteLine();
        }

        private void DriveMaxIndexArrSum()
        {
            var classRef = new MaxIndexArrSum();

            var array = new int[] { 1, 20, 2, 10 };
            var maxSum = classRef.FindMaxSum(array);
            Console.WriteLine("Max sum is {0}", maxSum);

            array = new int[] { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            maxSum = classRef.FindMaxSum(array);
            Console.WriteLine("Max sum is {0}", maxSum);
        }
    }
}
