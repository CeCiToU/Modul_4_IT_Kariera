using System;
using System.Linq;

namespace ConsoleApp321
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFromLongestPatern = 0;
            int longestPatern = 0;
            int currentPatern = 1;
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] == arr[i + 1])
                {
                    currentPatern++;
                    if (currentPatern > longestPatern)
                    {
                        longestPatern = currentPatern;
                        numFromLongestPatern = arr[i];
                    }
                }
                else
                {
                    currentPatern = 1;
                }
            }
            if (longestPatern == 0)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                for (int i = 0; i < longestPatern; i++)
                {
                    Console.Write($"{numFromLongestPatern} ");
                }
            }
        }
    }
}
