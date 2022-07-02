using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp323
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            try
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int i = 0; i < arr.Length; i++)
                {
                    stack.Push(arr[i]);
                }
            }
            catch
            {
                Console.WriteLine("(empty)");
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
