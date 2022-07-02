using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp322
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if(!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]] += 1;
                }
            }
            foreach(var number in dict)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
