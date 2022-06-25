using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp315
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            List<int> arr2 = new List<int>(arr1.Count + 1);
            arr2.Add(num);
            for(int i = 0; i < arr1.Count; i++)
            {
                arr2.Add(arr1[i]);
            }
            arr2.Sort();
            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine(string.Join(", ", arr2));
        }
    }
}
