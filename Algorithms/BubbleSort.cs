using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class BubbleSort
    {
        public static int[] Sort(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = sequence.Length - 1; j > i; j--)
                {
                    if (sequence[j] < sequence[j - 1])
                    {
                        (sequence[j], sequence[j - 1]) = (sequence[j - 1], sequence[j]);
                    }
                }
            }

            return sequence;
        }
    }
}
