using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp331
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 4 5 1 2 6
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list = BubbleSort(list);
            Console.WriteLine(string.Join(" ", list));
        }
        public static List<int> BubbleSort(List<int> list)
        {
            
            int currentNum = 0;
            for (int i = 0; i < list.Count - 2; i++)
            {
                for (int j = 0; j < list.Count - 2; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        currentNum = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = currentNum;
                    }
                }
            }
            return list;
        }

    }
}
