using System;

namespace DataStructures
{
    internal class Stack
    {
        public int[] Data { get; set; }
        public int Top { get; set; } = -1;

        public Stack(int length)
        {
            Data = new int[length];
        }

        public Stack(): this(8) { }

        private bool StackEmpty() => Top == 0;

        public void Push(int value)
        {
            if (Top < Data.Length - 1)
            {
                Top++;
                Data[Top] = value;
            }
            else throw new Exception("Stack Overflow");
        }

        public int Pop()
        {
            if (Top >= 0)
            {
                int x = Data[Top];
                Top--;
                Data[Top + 1] = 0;
                return x;
            }

            throw new Exception("Stack Underflow");
        }
    }
}
