namespace ConsoleApp313
{
    internal class MyStack<T>
    {

        private int count;
        private Node<T> top;

        public MyStack<T> Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.Next = top;
                top = node;
            }
            Count++;
            return this;
        }
        public T Pop()
        {
            CheckIfEmpty();
            T value = top.Value;
            top = top.Next;
            Count--;
            return value;
        }
        public T Peek()
        {
            CheckIfEmpty();
            T result = top.Value;
            return top.Value;
        }
        public int StackCount()
        {
            return Count;
        }
        public void Clear()
        {
            Node<T> currentNode = top;
            while (top != null)
            {
                top = null;
                currentNode.Next = null;
                currentNode = currentNode.Next;
            }
        }
        public bool Contains(T value)
        {
            Node<T> currentNode = top;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
        public T[] ToArray()
        {
            CheckIfEmpty();
            Node<T> node = top;
            T[] array = new T[Count];
            for(int i = 0; i < Count; i++)
            {
                array[i] = node.Value;
                node = node.Next;
            }
            return array;
        }

        public int Count { get => count; private set => count = value; }
        private Node<T> Top { get => top; set => top = value; }

        class Node<T>
        {
            private T value;
            private Node<T> next;

            public T Value { get => value; set => this.value = value; }
            public Node<T> Next { get => next; set => next = value; }

            public Node(T value, Node<T> prevNode)
            {
                this.value = value;
                prevNode.next = this;
            }
            public Node(T value)
            {
                this.value = value;
            }
        }
        public MyStack()
        {

        }

        private void CheckIfEmpty()
        {
            if (top == null)
            {
                throw new System.Exception("Queue is empty!");
            }
        }
    }
}