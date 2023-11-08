namespace Algorithms
{
    internal class MergeSort
    {
        private static void Merge(int[] a, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] left = new int[n1];
            int[] right = new int[n2];

            int i, j, k = p;
            for (i = 0; i < n1; i++) left[i] = a[p + i];
            for (j = 0; j < n2; j++) right[j] = a[q + j + 1];

            i = j = 0;
            
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j]) 
                    a[k++] = left[i++];
                
                else
                    a[k++] = right[j++];
            }

            while (i < n1)
            {
                a[k++] = left[i++];
            }
            while (j < n2)
            {
                a[k++] = right[j++];
            }
        }

        public static int[] Sort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r)/2;

                Sort(a, p, q);
                Sort(a, q + 1, r);

                Merge(a, p, q, r);
            }

            return a;
        }
    }
}
