namespace Algorithms
{
    internal class LinearSearch
    {
        public static int? Search(int[] Sequence, int SearchValue)
        {
            int? index = null;
            for (int i = 0; i < Sequence.Length; i++)
            {
                if (Sequence[i] == SearchValue)
                {
                    index = i;
                    break;
                }   
            }

            return index;
        }
    }
}
