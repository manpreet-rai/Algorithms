namespace Algorithms
{
    internal class InsertionSort
    {
        public int[] Sequence {  get; set; }

        public InsertionSort() { }

        public InsertionSort(int[] sequenceArray) {  Sequence = sequenceArray; }

        public int[] IncreasingSort()
        {
            for (int j = 1; j < Sequence.Length; j++)
            {
                int key = Sequence[j];
                int i = j - 1;
                while (i >= 0 && Sequence[i] > key)
                {
                    Sequence[i + 1] = Sequence[i];
                    i--;
                }
                Sequence[i + 1] = key;
            }

            return Sequence;
        }

        public int[] DecreasingSort()
        {
            for (int j = 1; j < Sequence.Length; j++)
            {
                int key = Sequence[j];
                int i = j - 1;
                while (i >= 0 && Sequence[i] < key)
                {
                    Sequence[i + 1] = Sequence[i];
                    i--;
                }
                Sequence[i + 1] = key;
            }

            return Sequence;
        }
    }
}
