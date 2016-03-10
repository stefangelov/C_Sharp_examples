using System;

namespace _07_LinkedQueue
{
    public class LinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public int Count { get; private set; }
        public void Enqueue(T element) 
        {
            QueueNode<T> newNode = new QueueNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.NextNode= this.head;
                this.head.PrevNode = newNode;
                this.head = newNode;
            }
            this.Count++;
        }
        public T Dequeue() 
        {
            if (this.Count < 1)
            {
                throw new IndexOutOfRangeException("There is no elements to pop!");
            }

            QueueNode<T> tempNode = this.tail;

            this.tail = this.tail.PrevNode;

            this.Count--;

            return tempNode.Value;
        }
        public T[] ToArray()
        {
            T[] resultArr = new T[this.Count];

            int counterForResultArr = 0;

            if (this.head.Equals(null) && this.tail.Equals(null))
            {
                return new T[this.Count];
            }

            do
            {
                resultArr[counterForResultArr] = this.tail.Value;
                counterForResultArr++;
                this.tail = this.tail.PrevNode;
                
            } while (this.tail != null);

            return resultArr;

        }

        private class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }
            
            // A can't do it wihtowt this ctor
            public QueueNode(T value)
            {
                this.Value = value;
            }
        }
    }
}
