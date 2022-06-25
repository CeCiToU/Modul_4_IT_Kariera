using System;
using System.Linq;

namespace ConsoleApp317
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(i + j + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
