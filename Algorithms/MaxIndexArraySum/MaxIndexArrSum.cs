
using System;

namespace Algorithms.MaxIndexArraySum
{
    public class MaxIndexArrSum
    {
        public int FindMaxSum(int[] array)
        {
            var maxSum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                maxSum = Math.Max(maxSum, FindIndexArraySum(array));
                RotateArray(ref array);
            }

            return maxSum;
        }

        private int FindIndexArraySum(int[] array)
        {
            var sum = 0;

            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i]*i;
            }

            return sum;
        }

        private void RotateArray(ref int[] array)
        {
            var lastElement = array[array.Length - 1];

            for (var i = array.Length-1; i >0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }
    }
}
