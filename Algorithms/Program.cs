using System;
using System.Diagnostics;
using Algorithms.MaximumPathSumInBinaryTree;

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
            DriveMaximumPathSumInBinaryTree();
        }

        private void DriveMaximumPathSumInBinaryTree()
        {
            var classRefernece = new MaxPathSumInBinaryTree();
            var root = classRefernece.BootStrapTree1();
            var res = 0;
            classRefernece.FindMaxSum(root, ref res);
            Debug.WriteLine(String.Format("Max sum of one of the branch is : {0}", res));

            root = classRefernece.BootStrapTree2();
            res = 0;
            classRefernece.FindMaxSum(root, ref res);
            Debug.WriteLine(String.Format("Max sum of one of the branch is : {0}", res));
        }
    }
}
