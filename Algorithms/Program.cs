using System;
using System.Diagnostics;
using Algorithms.MaximumPathSumInBinaryTree;
using Algorithms.MinimumDepthInBinaryTree;
using Algorithms.RemoveHalfNodes;
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
            DriveRemoveHalfNodes();
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
    }
}
