using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class QuickSort
    {
        private static int Partition(int[] a, int p, int r)
        {
            int x = a[r];
            int i = p - 1;
            for (int j = p; j <= r - 1; j++)
            {
                if (a[j] <= x)
                {
                    i++;
                    (a[i], a[j]) = (a[j], a[i]);
                }
            }

            (a[i + 1], a[r]) = (a[r], a[i + 1]);
            return i + 1;
        }

        public static int[] Sort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(a, p, r);
                Sort(a, p, q - 1);
                Sort(a, q + 1, r);
            }
            
            return a;
        }
    }
}
