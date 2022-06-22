using System;
using System.Linq;

namespace ConsoleApp306
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сложността му е 4?
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int checkNum = int.Parse(Console.ReadLine());
            if (arr.Contains(checkNum))
            {
                Console.WriteLine($"{checkNum} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{checkNum} Not exists in the List");
            }
        }
    }
}
