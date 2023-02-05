using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Queues
{
    public class ArrayQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;

        public int Count => _tail - _head;
        public bool IsEmpty => Count == 0;

        public ArrayQueue()
        {
            _queue = new T[4];
        }

        public ArrayQueue(int capacity)
        {
            _queue = new T[capacity];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enqueue(T item)
        {
            if (_queue.Length == _tail)
            {
                T[] lar = new T[Count * 2];
                Array.Copy(_queue, lar, Count);
                _queue = lar;
            }

            _queue[_tail++] = item;
        }

        public void Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            _queue[_head++] = default(T);

            if (IsEmpty)
            {
                _head = _tail = 0;
            }
        }

        public T Peek()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException();
            }

            return _queue[_head];
        }
    }
}
