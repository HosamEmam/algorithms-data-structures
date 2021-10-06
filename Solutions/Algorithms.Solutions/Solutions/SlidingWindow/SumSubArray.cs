using System;

namespace Solutions.SlidingWindow
{
    public class SumSubArray
    {
        public static int? GetMaxSum(int[] arr, int num)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            int tempSum = 0;
            int maxSum = 0;
            //Get first sum
            for (int i = 0; i < num; i++)
            {
                tempSum += arr[i];
            }

            maxSum = tempSum;

            for (int i = num; i < arr.Length; i++)
            {
                tempSum = tempSum - arr[i - num] + arr[i];
                if (tempSum > maxSum)
                    maxSum = tempSum;
            }

            return maxSum;
        }
    }
}
