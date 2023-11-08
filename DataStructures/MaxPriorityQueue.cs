using System;
using Algorithms;

namespace DataStructures
{
    internal class MaxPriorityQueue
    {
        public static void Insert(ref int[] a, int key)
        {
            int[] temp = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = a[i];
            }
            temp[a.Length] = int.MinValue;
            a = temp;
            IncreaseKey(ref a, a.Length-1, key);
        }

        public static int? Maximum(int[] a)
        {
            return a.Length != 0 ? a[0] : null;
        }

        public static int? ExtractMax(ref int[] a)
        {
            int? max = Maximum(a);
            if (max != null)
            {
                a[0] = a[^1]; // Last element
                HeapSort.HeapSize--;
                a = a[0..HeapSort.HeapSize];
                HeapSort.MaxHeapify(a, 0);
            }
            return max;
        }

        public static void IncreaseKey(ref int[] a, int presentKey, int updatedKey)
        {
            a[presentKey] = updatedKey;
            while (presentKey > 0 && a[HeapSort.Parent(presentKey)] < a[presentKey])
            {
                (a[presentKey], a[HeapSort.Parent(presentKey)]) = (a[HeapSort.Parent(presentKey)], a[presentKey]);
                presentKey = HeapSort.Parent(presentKey);
            }
        }

        public static void Init(ref int[] a)
        {
            int[] temp = Array.Empty<int>();
            for (int i = 0; i < a.Length; i++)
            {
                Insert(ref temp, a[i]);
            }

            a = temp;
        }
    }
}
