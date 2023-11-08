namespace Algorithms
{
    internal class InsertionSort
    {
        public static int[] IncreasingSort(int[] sequence)
        {
            for (int j = 1; j < sequence.Length; j++)
            {
                int key = sequence[j];
                int i = j - 1;
                while (i >= 0 && sequence[i] > key)
                {
                    sequence[i + 1] = sequence[i];
                    i--;
                }
                sequence[i + 1] = key;
            }

            return sequence;
        }

        public static int[] DecreasingSort(int[] sequence)
        {
            for (int j = 1; j < sequence.Length; j++)
            {
                int key = sequence[j];
                int i = j - 1;
                while (i >= 0 && sequence[i] < key)
                {
                    sequence[i + 1] = sequence[i];
                    i--;
                }
                sequence[i + 1] = key;
            }

            return sequence;
        }
    }
}
