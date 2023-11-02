using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class NBitAddition
    {
        public int[] A {  get; set; } = new int[8]; // Size 8 bits
        public int[] B { get; set; } = new int[8]; // Size 8 bits

        public int[] C { get; set; } = new int[9]; // Size 9 bits, i.e., 8 for sum, 1 for carry

        public NBitAddition() { }
        public NBitAddition(int[] a, int[] b)
        {
            A = a;
            B = b;
        }

        public int[] Sum()
        {
            int carry = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                C[i + 1] = (A[i] + B[i] + carry) % 2;
                if ((A[i] + B[i] + carry) >= 2)
                    carry = 1;
                else
                    carry = 0;
            }

            C[0] = carry;

            return C;
        }
    }
}
