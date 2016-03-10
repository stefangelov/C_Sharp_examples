using System;

namespace ArrStackClass
{
    public class ArrayStack<T>
    {
        private T[] elements;

        public int Count { get; private set; }

        private const int InitialCapacity = 16;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count < 1)
            {
                throw new IndexOutOfRangeException("There is no elements to pop!");
            }
            T returnValue = this.elements[this.Count - 1];
            this.Count--;
            return returnValue;
        }
        public T[] ToArray()
        {
            T[] stackToArr = new T[this.Count];
            Array.Copy(this.elements, stackToArr, this.Count);
            Array.Reverse(stackToArr);  
            return stackToArr;
        }
        private void Grow()
        {
            T[] temp = new T[elements.Length];
            Array.Copy(this.elements, temp, this.Count);
            this.elements = new T[this.Count * 2];
            Array.Copy(temp, this.elements, temp.Length);
        }
    }
}