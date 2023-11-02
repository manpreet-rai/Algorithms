namespace Algorithms
{
    internal class LinearSearch
    {
        public int[] Sequence {  get; set; }
        public int SearchValue { get; set; }

        public int? Index { get; set; } = null;

        public LinearSearch() { }

        public LinearSearch(int[] sequence, int searchValue)
        {
            Sequence = sequence;
            SearchValue = searchValue;
        }

        public int? Search()
        {
            for (int i = 0; i < Sequence.Length; i++)
            {
                if (Sequence[i] == SearchValue)
                {
                    Index = i;
                    break;
                }
                else
                {
                    Index = null;
                }
                
            }

            return Index;
        }
    }
}
