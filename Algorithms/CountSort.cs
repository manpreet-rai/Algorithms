namespace Algorithms
{
    internal class CountSort
    {
        private static int Max(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            return max;
        }

        public static int[] Sort(int[] a)
        {
            int[] b = new int[a.Length];
            int[] c = new int[Max(a) + 1];

            for (int i = 0; i < a.Length; i++) // Count each element in a, store the count in c
                c[a[i]]++;

            for (int i = 1; i < c.Length; i++) // This provides position of elements in a, where to put in b
                c[i] += c[i - 1];

            for (int i = a.Length - 1; i >= 0; i--)
            {
                b[c[a[i]] - 1] = a[i];
                c[a[i]]--;
            }

            return b;
        }
    }
}
