using System;

namespace ConsoleApp309
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("iskame po4ivka");
            myList.Add("iskame po4ivka");
            myList.Add("iskame po4ivka");
            myList.Add("iskame po4ivka");
            myList.Add("iskame po4ivka");
            Console.WriteLine(myList[0]);
            Console.WriteLine("Capacity = " + myList.Capacity);
            Console.WriteLine("Count = " + myList.Count);
            myList.RemoveAt(3);
            myList.RemoveAt(2);
            myList.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine("Capacity = " + myList.Capacity);
            Console.WriteLine("Count = " + myList.Count);
            myList.RemoveAt(1);
            myList.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine("Capacity = " + myList.Capacity);
            Console.WriteLine("Count = " + myList.Count);
        }
    }
}
