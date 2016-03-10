using System;

namespace LinkedStackClass
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element) 
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }
        public T Pop() 
        {
            if (this.Count < 1)
            {
                throw new IndexOutOfRangeException("There is no elements to pop!");
            }

            Node<T> tempNode = firstNode;
            firstNode = firstNode.NextNode;
            this.Count--;

            return tempNode.Value;
        }
        public T[] ToArray() 
        {
            T[] resultArr = new T[this.Count];
            int counterForResultArr = 0;

            if (this.firstNode == null)
            {
                return new T[this.Count];   
            }

            do
            {
                resultArr[counterForResultArr] = this.firstNode.Value;
                counterForResultArr++;
                this.firstNode = this.firstNode.NextNode;
            } 
            while (this.firstNode != null);
            
            return resultArr;
        }
        private void Grow() 
        {
            // Nothing TODO

            throw new NotImplementedException("Unnecessary method!");
        }
        private class Node<T>
        {
            private T value;
            public Node<T> NextNode { get; set; }
            public T Value { get { return this.value; } }
            public Node(T value, Node<T> nextNode = null) 
            {
                this.value = value;
                this.NextNode = nextNode; 
            }
        }

    }
}
