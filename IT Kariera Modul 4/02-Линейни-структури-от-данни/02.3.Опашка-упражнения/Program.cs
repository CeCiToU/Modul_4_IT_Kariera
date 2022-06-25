using System;

namespace ConsoleApp312
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(8);
            queue.Enqueue(2);
           queue.Enqueue(1);

            int[] arr = queue.ToArray();

            Console.WriteLine("Array 1: " + string.Join(", ", arr));
            Console.WriteLine();
            Console.WriteLine("Peek = " + queue.Peek());
            Console.WriteLine("Count = " + queue.QueueCount());
            Console.WriteLine();

            queue.Dequeue();
            queue.Dequeue();
            int[] array = queue.ToArray();

            Console.WriteLine("Array 2: " + string.Join(", ", array));
            Console.WriteLine();
            Console.WriteLine("Peek = " + queue.Peek());
            Console.WriteLine("Count = " + queue.QueueCount());
            Console.WriteLine();
            Console.WriteLine("Does it contains \"2\"? " + queue.Contains(2));
            Console.WriteLine();

            queue.Clear();

            Console.WriteLine("Does it still contains \"2\"? " + queue.Contains(2));
            Console.WriteLine();

            int[] array3 = queue.ToArray();

            Console.WriteLine("Array 3: " + string.Join(", ", array));


        }
    }
}
