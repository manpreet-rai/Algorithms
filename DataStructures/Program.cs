using System;
using Algorithms;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 57, 49, 52, 41, 38, 3, 9, 26 };

            Algorithms.Program.PrintIntArray(seq, "Sequence: ");
            Console.WriteLine($"Max: {MaxPriorityQueue.Maximum(seq)}");
            Console.WriteLine($"Extract Max: {MaxPriorityQueue.ExtractMax(ref seq)}");
            Algorithms.Program.PrintIntArray(seq, "After Extract Max, Sequence: ");
            Console.WriteLine($"Insert 89 into Sequence: ");
            MaxPriorityQueue.Insert(ref seq, 89);
            Algorithms.Program.PrintIntArray(seq, "Insert 89, Sequence: ");
        }
    }
}