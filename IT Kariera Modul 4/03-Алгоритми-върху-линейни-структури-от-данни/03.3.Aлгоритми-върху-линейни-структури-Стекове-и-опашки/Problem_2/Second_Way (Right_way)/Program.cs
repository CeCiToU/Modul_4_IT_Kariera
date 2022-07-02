using System;
using System.Collections.Generic;

namespace ConsoleApp326
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> S = new Queue<int>();
            int num = int.Parse(Console.ReadLine());
            S.Enqueue(num);
            List<int> list = new List<int>();
            list.Add(num);
            int currentS = S.Dequeue();
            int i = 1;
            for (int j = 0; j < 50; j++)
            {
                switch (i)
                {
                    case 1:
                        int currentProb1 = currentS + 1;
                        S.Enqueue(currentProb1);
                        list.Add(currentProb1);
                        break;
                    case 2:
                        int currentProb2 = 2 * (currentS) + 1;
                        S.Enqueue(currentProb2);
                        list.Add(currentProb2);
                        break;
                    case 3:
                        int currentProb3 = currentS + 2;
                        S.Enqueue(currentProb3);
                        list.Add(currentProb3);
                        break;
                    case 4:
                        i = 0;
                        currentS = S.Dequeue();
                        break;
                }
                i++;

            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
