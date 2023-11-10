namespace Algorithms
{
    internal class QuickSort
    {
        private static int Partition(int[] a, int min, int max)
        {
            int x = a[max];
            int i = min - 1;
            for (int j = min; j <= max - 1; j++)
            {
                if (a[j] <= x)
                {
                    i++;
                    (a[i], a[j]) = (a[j], a[i]);
                }
            }

            (a[i + 1], a[max]) = (a[max], a[i + 1]);
            return i + 1;
        }

        public static int[] Sort(int[] a, int min, int max)
        {
            if (min < max)
            {
                int mid = Partition(a, min, max);
                Sort(a, min, mid - 1);
                Sort(a, mid + 1, max);
            }
            
            return a;
        }
    }
}
