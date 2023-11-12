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
            int[] newQueue = new int[] { 15, 13, 9, 5, 12, 8, 7, 4 };
            MaxPriorityQueue.Init(ref newQueue);
            Algorithms.Program.PrintIntArray(newQueue, "New Queue, Sequence: ");

            Stack stack = new Stack(16);
            Console.WriteLine($"Current Stack Top: {stack.Top}");
            stack.Push(13);
            stack.Push(9);
            stack.Push(15);
            Algorithms.Program.PrintIntArray(stack.Data, "After 3 pushes: ");

            Console.WriteLine($"Current Stack Top: {stack.Top}");
            Console.WriteLine($"Pop value: {stack.Pop()}");
            Console.WriteLine($"Pop value: {stack.Pop()}");
            Console.WriteLine($"Pop value: {stack.Pop()}");
            Console.WriteLine($"Current Stack Top: {stack.Top}");
            Algorithms.Program.PrintIntArray(stack.Data, "After 3 pops: ");
        }
    }
}