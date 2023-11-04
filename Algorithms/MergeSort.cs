namespace Algorithms
{
    internal class MergeSort
    {
        private void Merge(int[] A, int P, int Q, int R)
        {
            int n1 = Q - P + 1;
            int n2 = R - Q;

            int[] left = new int[n1];
            int[] right = new int[n2];

            int i, j, k = P;
            for (i = 0; i < n1; i++) left[i] = A[P + i];
            for (j = 0; j < n2; j++) right[j] = A[Q + j + 1];

            i = j = 0;
            
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                A[k++] = left[i++];
            }
            while (j < n2)
            {
                A[k++] = right[j++];
            }
        }

        public int[] Sort(int[] A, int P, int R)
        {
            if (P < R)
            {
                int Q = (P + R)/2;

                Sort(A, P, Q);
                Sort(A, Q + 1, R);

                Merge(A, P, Q, R);
            }

            return A;
        }
    }
}
