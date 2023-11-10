namespace Algorithms
{
    internal class BinarySearch
    {
        public static int? Search(int[] a, int key, int min, int max) // This BinarySearch operates on sorted arrays only
        {
            if (min > max) return null;
            else
            {
                int mid = (min + max) / 2;

                if (a[mid] == key)
                    return mid;
                else if (a[mid] < key)
                    return Search(a, key, mid + 1, max);
                else
                    return Search(a, key, min, mid - 1);
            }
        }
    }
}
