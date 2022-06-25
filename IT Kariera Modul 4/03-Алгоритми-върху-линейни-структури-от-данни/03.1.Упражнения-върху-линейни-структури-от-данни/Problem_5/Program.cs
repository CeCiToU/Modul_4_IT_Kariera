using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp316
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
                double sum = list.Sum();
                double average = sum / list.Count;
                Console.Write("Sum=" + sum + "; ");
                Console.WriteLine($"Average={average:F2}");
            }
            catch
            {
                Console.WriteLine("Sum=0; Average=0.00");
            }
        }
    }
}
