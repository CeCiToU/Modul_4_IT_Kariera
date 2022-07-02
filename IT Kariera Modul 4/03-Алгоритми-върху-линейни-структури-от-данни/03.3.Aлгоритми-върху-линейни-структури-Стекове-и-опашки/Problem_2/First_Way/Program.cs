using System;
using System.Collections.Generic;

namespace ConsoleApp324
{
    class Program
    {
        static void Main(string[] args)
        {
            //it's not the right way!!!
            //int num = int.Parse(Console.ReadLine());
            int num = 2;
            int times = 0;
            List<int> list = new List<int>();
            int S1 = num;
            list.Add(S1);

            int S = 0;


            int S2 = S + 1;


            int S3 = 2 * S + 1;
            int S4 = S + 2;


            list.Add(S2);
            list.Add(S3);
            list.Add(S4);

            int S5 = num + 2;
            int S6 = 2 * (num + 1) + 1;
            int S7 = num + 3;
            list.Add(S5);
            list.Add(S6);
            list.Add(S7);

            int S8 = (2 * num + 1) + 1;
            int S9 = 2 * (2 * num + 1) + 1;
            int S10 = (2 * num + 1) + 2;
            list.Add(S8);
            list.Add(S9);
            list.Add(S10);

            int S11 = (num + 2) + 1;
            int S12 = 2 * (num + 2) + 1;
            int S13 = (num + 2) + 2;
            list.Add(S11);
            list.Add(S12);
            list.Add(S13);

            int S14 = (num + 2) + 1;
            int S15 = 2 * (num + 2) + 1;
            int S16 = (num + 2) + 2;
            list.Add(S14);
            list.Add(S15);
            list.Add(S16);

            int S17 = (2 *num + 3) + 1;
            int S18 = 2 * (2 * num + 3) + 1;
            int S19 = (2 * num + 3) + 2;
            list.Add(S17);
            list.Add(S18);
            list.Add(S19);

            int S20 = (num + 3) + 1;
            int S21 = 2 * (num + 3) + 1;
            int S22 = (num + 3) + 2;
            list.Add(S20);
            list.Add(S21);
            list.Add(S22);

            int S23 = (2 * num + 2) + 1;
            int S24 = 2 * (2 * num + 2) + 1;
            int S25 = (2 * num + 2) + 2;
            list.Add(S23);
            list.Add(S24);
            list.Add(S25);

            int S26 = (4 * num + 3) + 1;
            int S27 = 2 * (4 * num + 3) + 1;
            int S28 = (4 * num + 3) + 2;
            list.Add(S26);
            list.Add(S27);
            list.Add(S28);

            int S29 = (2 * num + 3) + 1;
            int S30 = 2 * (2 * num + 3) + 1;
            int S31 = (2 * num + 3) + 2;
            list.Add(S29);
            list.Add(S30);
            list.Add(S31);

            int S32 = (num + 3) + 1;
            int S33 = 2 * (num + 3) + 1;
            int S34 = (num + 3) + 2;
            list.Add(S32);
            list.Add(S33);
            list.Add(S34);

            int S35 = (2 * num + 6) + 1;
            int S36 = 2 * (2 * num + 6) + 1;
            int S37 = (2 * num + 6) + 2;
            list.Add(S35);
            list.Add(S36);
            list.Add(S37);

            int S38 = (num + 4) + 1;
            int S39 = 2 * (num + 4) + 1;
            int S40 = (num + 4) + 2;
            list.Add(S38);
            list.Add(S39);
            list.Add(S40);

            int S41 = (num + 3) + 1;
            int S42 = 2 * (num + 3) + 1;
            int S43 = (num + 3) + 2;
            list.Add(S41);
            list.Add(S42);
            list.Add(S43);

            int S44 = (2 * num + 5) + 1;
            int S45 = 2 * (2 * num + 5) + 1;
            int S46 = (2 * num + 5) + 2;
            list.Add(S44);
            list.Add(S45);
            list.Add(S46);

            int S47 = (num + 4) + 1;
            int S48 = 2 * (num + 4) + 1;
            int S49 = (num + 4) + 2;
            list.Add(S47);
            list.Add(S48);
            list.Add(S49);

            int S50 = 2 * (num + 4) + 1;
            list.Add(S50);

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == 6)
                {
                    times++;
                }
            }
            Console.WriteLine("Times = " + times);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", list));




        }
        
    }
}
