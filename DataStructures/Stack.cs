using System;

namespace DataStructures
{
    internal class Stack
    {
        public int[] Data { get; set; }
        public int Top { get; set; } = -1;

        public Stack(int length)
        {
            data = new int[length];
        }

        public Stack(): this(8) { }

        private bool StackEmpty() => top == 0;

        public void Push(int value)
        {
            if (top < data.Length - 1)
            {
                top++;
                data[top] = value;
            }
            else throw new Exception("Stack Overflow");
        }

        public int Pop()
        {
            if (top >= 0)
            {
                int x = data[top];
                top--;
                data[top + 1] = 0;
                return x;
            }

            throw new Exception("Stack Underflow");
        }
    }
}
