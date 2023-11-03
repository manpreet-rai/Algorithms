namespace Algorithms
{
    internal class LinearSearch
    {
        public int[] Sequence {  get; set; }
        public int SearchValue { get; set; }

        public LinearSearch() { }

        public LinearSearch(int[] sequence, int searchValue)
        {
            Sequence = sequence;
            SearchValue = searchValue;
        }

        public int? Search()
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
