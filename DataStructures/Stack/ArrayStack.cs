using System;

namespace DataStructures.Stack
{
    public class ArrayStack<T>
    {
        private T[] _items;

        public ArrayStack()
        {
            const int defaulCapacity = 4;
            _items = new T[defaulCapacity];
        }

        public ArrayStack(int capacity)
        {
            _items = new T[capacity];
        }

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return _items[Count - 1];
            }
        }

        public void Pop()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {
                _items[Count - 1] = default;
                Count--;
            }
        }

        public void Push(T v)
        {
            if(_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items= largerArray;
            }

            _items[Count] = v;
            Count++;
        }
    }
}
