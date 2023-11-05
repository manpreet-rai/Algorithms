using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class MaxSubArray
    {
        private (int left, int right, int sum) FindMidCrossingArray(int[] A, int P, int Q, int R)
        {
            int lSum = int.MinValue, rSum = int.MinValue, sum = 0, left = P, right = R;
            for (int i = Q; i >= P; i--)
            {
                sum += A[i];
                if (sum > lSum)
                {
                    lSum = sum;
                    left = i;
                }
            }
            sum = 0;
            for (int i = Q + 1; i <= R; i++)
            {
                sum += A[i];
                if (sum > rSum)
                {
                    rSum = sum;
                    right = i;
                }
            }

            return (left, right, lSum + rSum);
        }

        public (int left, int right, int sum) FindMaxSubArray(int[] A, int P, int R)
        {
            if (P == R) return (P, R, A[P]);

            int Q = (P + R) / 2;
            (int leftLow, int leftHigh, int leftSum) = FindMaxSubArray(A, P, Q);
            (int rightLow, int rightHigh, int rightSum) = FindMaxSubArray(A, Q + 1, R);
            (int crossLow, int crossHigh, int crossSum) = FindMidCrossingArray(A, P, Q, R);

            if (leftSum >= rightSum && leftSum >= crossSum)
                return (leftLow, leftHigh, leftSum);
            else if (rightSum >= leftSum && rightSum >= crossSum)
                return (rightLow, rightHigh, rightSum);
            else 
                return (crossLow, crossHigh, crossSum);
        }
    }
}
