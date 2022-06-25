using System;

namespace ConsoleApp318
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write(i+ "" + j + " ");
                    num++;
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine(num);
        }
    }
}
