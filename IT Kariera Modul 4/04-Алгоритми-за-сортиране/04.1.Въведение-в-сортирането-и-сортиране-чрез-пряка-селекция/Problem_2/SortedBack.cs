using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp330
{
    internal class SortedBack<T>
    {
        private T[] items;
        List<T> sortedList = new List<T>();
        private List<int> list;

        public SortedBack(List<T> list)
        {
            for (int i = list.Count; i > 0; i--)
            {
                int index = list.IndexOf(list.Min());
                sortedList.Add(list.Min());
                list.RemoveAt(index);

            }
            sortedList.Reverse();
        }
        public T this[int index] { get { return this.items[index]; } set { this.items[index] = value; } }

        public override string ToString()
        {
            return string.Join(" ", sortedList);
        }
    }
}