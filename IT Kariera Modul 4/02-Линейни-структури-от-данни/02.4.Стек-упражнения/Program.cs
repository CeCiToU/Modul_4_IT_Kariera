using System;

namespace ConsoleApp313
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(5);
            stack.Push(4);
            stack.Push(8);
            stack.Push(2);
            stack.Push(1);

            int[] arr = stack.ToArray();

            Console.WriteLine("Array 1: " + string.Join(", ", arr));
            Console.WriteLine();
            Console.WriteLine("Peek = " + stack.Peek());
            Console.WriteLine("Count = " + stack.StackCount());
            Console.WriteLine();

            stack.Pop();
            stack.Pop();
            int[] array = stack.ToArray();

            Console.WriteLine("Array 2: " + string.Join(", ", array));
            Console.WriteLine();
            Console.WriteLine("Peek = " + stack.Peek());
            Console.WriteLine("Count = " + stack.StackCount());
            Console.WriteLine();
            Console.WriteLine("Does it contains \"2\"? " + stack.Contains(2));
            Console.WriteLine();

            stack.Clear();

            Console.WriteLine("Does it still contains \"2\"? " + stack.Contains(2));
            Console.WriteLine();

            int[] array3 = stack.ToArray();

            Console.WriteLine("Array 3: " + string.Join(", ", array));
        }
    }
}
