namespace Algorithms
{
    internal class BinarySearch
    {
        public int? Search(int[] A, int key, int P, int R) // This BinarySearch operates on sorted arrays only
        {
            if (P > R) return null;
            else
            {
                int Q = (P + R) / 2;

                if (A[Q] == key)
                    return Q;
                else if (A[Q] < key)
                    return Search(A, key, Q + 1, R);
                else
                    return Search(A, key, P, Q - 1);
            }
        }
    }
}
