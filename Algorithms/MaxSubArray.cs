using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class MaxSubArray
    {
        private static (int left, int right, int sum) FindMidCrossingArray(int[] a, int min, int mid, int max)
        {
            int lSum = int.MinValue, rSum = int.MinValue, sum = 0, left = min, right = max;
            for (int i = mid; i >= min; i--)
            {
                sum += a[i];
                if (sum > lSum)
                {
                    lSum = sum;
                    left = i;
                }
            }
            sum = 0;
            for (int i = mid + 1; i <= max; i++)
            {
                sum += a[i];
                if (sum > rSum)
                {
                    rSum = sum;
                    right = i;
                }
            }

            return (left, right, lSum + rSum);
        }

        public static (int left, int right, int sum) FindMaxSubArray(int[] a, int min, int max)
        {
            if (min == max) return (min, max, a[min]);

            int mid = (min + max) / 2;
            (int leftLow, int leftHigh, int leftSum) = FindMaxSubArray(a, min, mid);
            (int rightLow, int rightHigh, int rightSum) = FindMaxSubArray(a, mid + 1, max);
            (int crossLow, int crossHigh, int crossSum) = FindMidCrossingArray(a, min, mid, max);

            if (leftSum >= rightSum && leftSum >= crossSum)
                return (leftLow, leftHigh, leftSum);
            else if (rightSum >= leftSum && rightSum >= crossSum)
                return (rightLow, rightHigh, rightSum);
            else 
                return (crossLow, crossHigh, crossSum);
        }
    }
}
