using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome to Algorithms *******");
            
            int[] sequence = { 5, 2, 4, 6, 1, 3 };
            Console.Write("Current Sequence: ");
            PrintIntArray(sequence);

            // Algorithm 2.1
            InsertionSort insertionSort = new InsertionSort(sequence);
            int[] increasingSortedArray = insertionSort.IncreasingSort();
            Console.Write("Insertion Sorted Increasing Sequence: ");
            PrintIntArray(increasingSortedArray);

            // Question 2.1-1
            InsertionSort insertionSort2 = new InsertionSort(new int[] {31, 41, 59, 26, 41, 58});
            int[] increasingSortedArray2 = insertionSort2.IncreasingSort();
            Console.Write("Insertion Sorted Increasing Sequence on [31, 41, 59, 26, 41, 58]: ");
            PrintIntArray(increasingSortedArray2);

            // Question 2.1-2
            int[] decreasingSortedArray = insertionSort.DecreasingSort(); // Uses Algorithm 2.1 instance and sequence
            Console.Write("Insertion Sorted Decreasing Sequence: ");
            PrintIntArray(decreasingSortedArray);

            //Question 2.1-3
            int[] searchSequence = new int[] { 31, 41, 59, 26, 41, 58 };
            LinearSearch linearSearch = new LinearSearch(searchSequence, 41);
            Console.WriteLine($"Index of {41} in [{string.Join(", ", searchSequence)}] is: {linearSearch.Search()}");
            linearSearch.SearchValue = 98;
            Console.WriteLine($"Index of {98} in [{string.Join(", ", searchSequence)}] is: {linearSearch.Search()}");


            //Helper Utility
            static void PrintIntArray(int[] sequence)
            {
                Console.WriteLine($"[ {string.Join(", ", sequence)} ]");
                Console.WriteLine("**********************************");
            }
        }
    }
}