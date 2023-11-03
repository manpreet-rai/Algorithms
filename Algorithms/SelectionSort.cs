namespace Algorithms
{
    internal class SelectionSort
    {
        public int[] Sequence {  get; set; }

        public SelectionSort() { }

        public SelectionSort(int[] sequenceArray) {  Sequence = sequenceArray; }

        public int[] Sort()
        {
            for (int i = 0; i < Sequence.Length - 1; i++)
            {
                int min = i;
                
                for (int j = i + 1; j < Sequence.Length; j++)
                {
                    if (Sequence[j] < Sequence[min])
                    {
                        min = j;
                    }
                }

                (Sequence[min], Sequence[i]) = (Sequence[i], Sequence[min]);
            }

            return Sequence;
        }
    }
}
