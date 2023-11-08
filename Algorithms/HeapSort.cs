using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class HeapSort
    {
        public static int Parent(int i) => i / 2;
        public static int Left(int i) => 2 * i + 1;
        public static int Right(int i) => 2 * i + 2;
        public static int HeapSize = 8;

        public static void MaxHeapify(int[] a, int i)
        {
            int l = Left(i);
            int r = Right(i);
            int largest;

            if (l < HeapSize && a[l] > a[i])
                largest = l;
            else
                largest = i;

            if (r < HeapSize && a[r] > a[largest])
                largest = r;

            if (largest != i)
            {
                (a[i], a[largest]) = (a[largest], a[i]);
                MaxHeapify(a, largest);
            }
        }

        public static void BuildMaxHeap(int[] a)
        {
            for (int i = (HeapSize - 1) / 2; i >= 0; i--)
                MaxHeapify(a, i);
        }

        public static int[] Sort(int[] a)
        {
            BuildMaxHeap(a);

            for (int i = (HeapSize - 1); i > 0; i--)
            {
                (a[0], a[i]) = (a[i], a[0]);
                HeapSize--;
                MaxHeapify(a, 0);
            }

            return a;
        }
    }
}
