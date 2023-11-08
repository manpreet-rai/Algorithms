using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("******* Welcome to Algorithms *******");
            
            int[] sequence = { 5, 2, 4, 6, 1, 3 };
            Console.Write("Current Sequence: ");
            PrintIntArray(sequence);


            // Algorithm 2.1
            // Refer InsertionSort.cs
            InsertionSort insertionSort = new InsertionSort();
            int[] increasingSortedArray = insertionSort.IncreasingSort(sequence);
            PrintIntArray(increasingSortedArray, "Insertion Sorted Increasing Sequence: ", true);


            // Question 2.1-1
            // Refer InsertionSort.cs
            InsertionSort insertionSort2 = new InsertionSort();
            int[] increasingSortedArray2 = insertionSort2.IncreasingSort(new[] { 31, 41, 59, 26, 41, 58 });
            PrintIntArray(increasingSortedArray2, "Insertion Sorted Increasing Sequence on [31, 41, 59, 26, 41, 58]: ", true);


            // Question 2.1-2
            // Refer InsertionSort.cs
            int[] decreasingSortedArray = insertionSort.DecreasingSort(sequence); // Uses Algorithm 2.1 instance and sequence
            PrintIntArray(decreasingSortedArray, "Insertion Sorted Decreasing Sequence: ", true);


            // Question 2.1-3
            // Refer LinearSearch.cs
            int[] searchSequence = { 31, 41, 59, 26, 41, 58 };
            LinearSearch linearSearch = new LinearSearch();
            Console.WriteLine($"Index of {41} in [{string.Join(", ", searchSequence)}] is: {linearSearch.Search(searchSequence, 41)}");
            Console.WriteLine($"Index of {98} in [{string.Join(", ", searchSequence)}] is: {linearSearch.Search(searchSequence, 98)}");
            Console.WriteLine("**********************************");


            // Question 2.1-4
            // Refer NBitAddition.cs
            int[] arrayA = { 0, 1, 1, 0, 1, 1, 1, 1 };
            int[] arrayB = { 1, 1, 1, 0, 0, 0, 1, 1 };
            NBitAddition nBitAddition = new NBitAddition(arrayA, arrayB);
            PrintIntArray(arrayA, "Array A:    ");
            PrintIntArray(arrayB, "Array B:    ");
            PrintIntArray(nBitAddition.Sum(), "Array C: ", true);


            // Question 2.2-2
            // Refer SelectionSort.cs
            sequence = new[] { 41, 59, 26, 41, 58 };
            PrintIntArray(sequence, "Current Sequence: ");
            SelectionSort selectionSort = new SelectionSort();
            PrintIntArray(selectionSort.Sort(sequence), "Selection Sorted Sequence: ", true);


            // Question 2.3-1
            // Refer MergeSort.cs
            sequence = new[] { 3, 41, 52, 26, 38, 57, 9, 49 };
            PrintIntArray(sequence, "Current Sequence: ");
            MergeSort mergeSort = new MergeSort();
            PrintIntArray(mergeSort.Sort(sequence, 0, sequence.Length - 1), "Merge Sorted Sequence: ", true);


            // Algorithm 2.3-5
            // Refer BinarySearch.cs
            sequence = new[] { 3, 9, 26, 38, 41, 49, 52, 57 };
            PrintIntArray(sequence, "Current Sequence: ");
            BinarySearch binarySearch = new BinarySearch();
            Console.WriteLine($"Index of {26} in [{string.Join(", ", sequence)}] is: {binarySearch.Search(sequence, 26, 0, sequence.Length - 1)}");
            Console.WriteLine($"Index of {98} in [{string.Join(", ", sequence)}] is: {binarySearch.Search(sequence, 98, 0, sequence.Length - 1)}");
            Console.WriteLine("**********************************");

            // Algorithm 2-2
            // Refer BubbleSort.cs
            sequence = new[] { 3, 41, 52, 26, 38, 57, 9, 49 };
            PrintIntArray(sequence, "Current Sequence: ");
            BubbleSort bubbleSort = new BubbleSort();
            PrintIntArray(bubbleSort.Sort(sequence), "Bubble Sorted Sequence: ", true);


            // Algorithm 3.1
            // Refer MaxSubArray.cs
            sequence = new[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            PrintIntArray(sequence, "Current Sequence: ");
            MaxSubArray maxSubArray = new MaxSubArray();
            (int min, int max, int sum) = maxSubArray.FindMaxSubArray(sequence, 0, 15);
            PrintIntArray(sequence[min..(max + 1)], $"Max Sub Array with sum = {sum}: ", true);


            // Algorithm 6.1
            // Refer HeapSort.cs
            sequence = new[] { 3, 41, 52, 26, 38, 57, 9, 49 };
            PrintIntArray(sequence, "Current Sequence");
            HeapSort heapSort = new HeapSort();
            PrintIntArray(heapSort.Sort(sequence), "Max Heap Sorted: ", true);

            // Helper Utility
            static void PrintIntArray(int[] sequence, string message = "", bool pattern = false)
            {
                Console.WriteLine($"{message}[ {string.Join(", ", sequence)} ]");
                if ( pattern ) Console.WriteLine("**********************************");
            }
        }
    }
}