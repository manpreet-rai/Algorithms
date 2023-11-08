using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class MaxSubArray
    {
        private static (int left, int right, int sum) FindMidCrossingArray(int[] a, int p, int q, int r)
        {
            int lSum = int.MinValue, rSum = int.MinValue, sum = 0, left = p, right = r;
            for (int i = q; i >= p; i--)
            {
                sum += a[i];
                if (sum > lSum)
                {
                    lSum = sum;
                    left = i;
                }
            }
            sum = 0;
            for (int i = q + 1; i <= r; i++)
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

        public static (int left, int right, int sum) FindMaxSubArray(int[] a, int p, int r)
        {
            if (p == r) return (p, r, a[p]);

            int q = (p + r) / 2;
            (int leftLow, int leftHigh, int leftSum) = FindMaxSubArray(a, p, q);
            (int rightLow, int rightHigh, int rightSum) = FindMaxSubArray(a, q + 1, r);
            (int crossLow, int crossHigh, int crossSum) = FindMidCrossingArray(a, p, q, r);

            if (leftSum >= rightSum && leftSum >= crossSum)
                return (leftLow, leftHigh, leftSum);
            else if (rightSum >= leftSum && rightSum >= crossSum)
                return (rightLow, rightHigh, rightSum);
            else 
                return (crossLow, crossHigh, crossSum);
        }
    }
}
