using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp328
{
    internal class SelectionSort<T>
    {
        private T[] items;
        List<T> sortedList = new List<T>();
        private List<int> list;

        public SelectionSort(List<T> list)
        {
            for(int i = list.Count; i > 0; i--)
            {
                int index = list.IndexOf(list.Min());
                sortedList.Add(list.Min());
                list.RemoveAt(index);
                
            }
        }
        public T this[int index]{get{ return this.items[index];}  set{this.items[index] = value;}}

        public override string ToString()
        {
            return string.Join(" ", sortedList);
        }
    }
}