namespace Algorithms
{
    internal class SelectionSort
    {
        public static int[] Sort(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                int min = i;
                
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[j] < sequence[min])
                    {
                        min = j;
                    }
                }

                (sequence[min], sequence[i]) = (sequence[i], sequence[min]);
            }

            return sequence;
        }
    }
}
