using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp328
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            SelectionSort<int> sortedArray = new SelectionSort<int>(list);
            Console.WriteLine(sortedArray);
        }

    }
}
