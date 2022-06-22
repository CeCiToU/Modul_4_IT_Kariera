using System;
namespace ConsoleApp309
{
    internal class MyList<T>
    {
        private T[] data;
        private int count;
        private int capacity;
        public MyList(int capacity = 4)
        {
            Capacity = capacity;
        }
        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.data[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                this.data[index] = value;
            }
        }
        public int Count
        {
            get => count;
            private set => count = value;
        }
        public int Capacity
        {
            get => capacity;
            private set => capacity = value;
        }

        public void Add(T items)
        {
            if (data == null)
            {
                data = new T[4];
            }
            if(Count == Capacity)
            {
                T[] copy = new T[Capacity * 2];
                for(int i = 0; i < data.Length; i++)
                {
                    copy[i] = data[i];
                }
                data = copy;
                Capacity = Capacity * 2;
            }
            data[Count] = items;
            count++;
        }
        public void RemoveAt(int index)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.data[index] = default(T);
            for(int i = index; i < Count; i++)
            {
                this.data[i] = data[i + 1];
            }
            Count--;
            if(Count < this.data.Length / 2 && Capacity  / 2 >= 4)
            {
                T[] copy = new T[Capacity / 2];
                for(int i = 0; i < Capacity / 2; i++)
                {
                    copy[i] = data[i];
                }
                data = copy;
                Capacity = Capacity / 2;
            }
        }
    }
}