using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp330
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedBack<int> sortedList = new SortedBack<int>(list);
            Console.WriteLine(sortedList);
        }
    }
}
