namespace ConsoleApp312
{
    internal class MyQueue<T>
    {
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

        private Node<T> head;
        private Node<T> tail;
        private int count;

        private Node<T> Head { get => head; set => head = value; }
        private Node<T> Tail { get => tail; set => tail = value; }
        public int Count { get => count; private set => count = value; }

        public MyQueue<T> Enqueue(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
            return this;
        }

        public T Dequeue()
        {
            CheckIfEmpty();
            T item = head.Value;
            head = head.Next;
            count--;
            return item;

        }

        public T Peek()
        {
            CheckIfEmpty();
            T item = Head.Value;
            return item;
        }

        public int QueueCount()
        {
            return count;
        }

        public void Clear()
        {
            Node<T> currentNode = head;
            while(head != null)
            {
                head = null;
                currentNode.Next = null;
                currentNode = currentNode.Next;
            }
        }

        public bool Contains(T value)
        {
            Node<T> currentNode = head;
            while(currentNode != null)
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
            T[] array = new T[count];
            Node<T> node = head;
            for(int i = 0; i < count; i++)
            {
                array[i] = node.Value;
                node = node.Next;
            }
            return array;
        }

        private void CheckIfEmpty()
        {
            if (head == null)
            {
                throw new System.Exception("Queue is empty!");
            }
        }

    }
}