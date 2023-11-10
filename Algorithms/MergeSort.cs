namespace Algorithms
{
    internal class MergeSort
    {
        private static void Merge(int[] a, int min, int mid, int max)
        {
            int n1 = mid - min + 1;
            int n2 = max - mid;

            int[] left = new int[n1];
            int[] right = new int[n2];

            int i, j, k = min;
            for (i = 0; i < n1; i++) left[i] = a[min + i];
            for (j = 0; j < n2; j++) right[j] = a[mid + j + 1];

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

        public static int[] Sort(int[] a, int min, int max)
        {
            if (min < max)
            {
                int mid = (min + max)/2;

                Sort(a, min, mid);
                Sort(a, mid + 1, max);

                Merge(a, min, mid, max);
            }

            return a;
        }
    }
}
