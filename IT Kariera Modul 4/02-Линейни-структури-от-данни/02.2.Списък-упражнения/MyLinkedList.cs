namespace ConsoleApp311
{
    public class MyLinkedList<T>
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

        public MyLinkedList() { }

        private Node<T> Head { get => head; set => head = value; }
        private Node<T> Tail { get => tail; set => tail = value; }
        public int Count { get => count; private set => count = value; }
        
        public void Add(T value)
        {
            Node<T> newNode;
            if(head == null)
            {
                newNode = new Node<T>(value);
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode = new Node<T>(value, tail);
                tail = newNode;
            }
            Count++;
        }

        public bool Remove(T value)
        {
            if (head.Value.Equals(value))
            {
                if (head.Next != null)
                {
                    head = head.Next;
                }
                Count--;
                return true;
            }
            Node<T> prevNode = null;
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    Count--;
                    if (prevNode != null)
                    {
                        if (tail == currentNode)
                        {
                            tail = prevNode;
                            return true;
                        }
                        prevNode.Next = currentNode.Next;
                        return true;
                    }
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public int LinkedListCount()
        {
            int num = Count;
            return num;
        }

        public void Clear()
        {
            Node<T> currentNode = head;
            while (head != null)
            {
                head = null;
                currentNode = currentNode.Next;
            }
        }

        public bool Contains(T value)
        {
            Node<T> currentNode = head;
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

        public void TrimExcess()
        {
            //Not implemented yet :))
        }

        public int IndexOf(T value)
        {
            int currentIndex = 0;
            Node<T> currentNode = head;
            while(currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentIndex;
                }
                currentNode = currentNode.Next;
                currentIndex++;
            }
            return -1;
        }
    }
}