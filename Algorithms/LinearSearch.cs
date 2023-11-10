namespace Algorithms
{
    internal class LinearSearch
    {
        public static int? Search(int[] sequence, int searchValue)
        {
            int? index = null;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == searchValue)
                {
                    index = i;
                    break;
                }   
            }

            return index;
        }
    }
}
