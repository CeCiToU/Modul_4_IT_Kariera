using System;

namespace ConsoleApp311
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("Dani");
            list.Add("Nati");
            list.Add("Presi");
            Console.WriteLine(list.IndexOf("Gosho"));
            list.Remove("Nati");
            Console.WriteLine(list.Contains("Dani"));
            Console.WriteLine(list.Contains("Nati"));
            Console.WriteLine(list.Contains("Presi"));
            list.Remove("Dani");
            Console.WriteLine(list.Contains("Dani"));
            Console.WriteLine(list.Count);
            list.Remove("Presi");
            Console.WriteLine(list.Count);
        }
    }
}
