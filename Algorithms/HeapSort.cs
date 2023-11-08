using System;

namespace Algorithms
{
    internal class HeapSort
    {
        private int Left(int i) => 2 * i + 1;
        private int Right(int i) => 2 * i + 2;
        private int _heapSize = 8;

        private void MaxHeapify(int[] a, int i)
        {
            int l = Left(i);
            int r = Right(i);
            int largest;

            if (l < _heapSize && a[l] > a[i])
                largest = l;
            else
                largest = i;

            if (r < _heapSize && a[r] > a[largest])
                largest = r;

            if (largest != i)
            {
                (a[i], a[largest]) = (a[largest], a[i]);
                MaxHeapify(a, largest);
            }
        }

        private void BuildMaxHeap(int[] a)
        {
            for (int i = (_heapSize - 1) / 2; i >= 0; i--)
                MaxHeapify(a, i);
        }

        public int[] Sort(int[] a)
        {
            BuildMaxHeap(a);

            for (int i = (_heapSize - 1); i > 0; i--)
            {
                (a[0], a[i]) = (a[i], a[0]);
                _heapSize--;
                MaxHeapify(a, 0);
            }

            return a;
        }
    }
}
