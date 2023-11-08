namespace Algorithms
{
    internal class BinarySearch
    {
        public static int? Search(int[] a, int key, int p, int r) // This BinarySearch operates on sorted arrays only
        {
            if (p > r) return null;
            else
            {
                int q = (p + r) / 2;

                if (a[q] == key)
                    return q;
                else if (a[q] < key)
                    return Search(a, key, q + 1, r);
                else
                    return Search(a, key, p, q - 1);
            }
        }
    }
}
