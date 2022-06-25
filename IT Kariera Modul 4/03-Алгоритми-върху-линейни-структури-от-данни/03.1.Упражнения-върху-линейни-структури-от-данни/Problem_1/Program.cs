using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp314
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            if (arr.Contains(num))
            {
                Console.WriteLine($"{num} Exist in the List!");
            }
            else
            {
                Console.WriteLine($"{num} Not exist in the List!");
            }
        }
    }
}
