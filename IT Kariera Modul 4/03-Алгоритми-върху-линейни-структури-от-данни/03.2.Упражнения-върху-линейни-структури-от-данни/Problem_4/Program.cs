using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp320
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            words.Sort();
            Console.WriteLine(string.Join(" ", words));
            
        }
    }
}
