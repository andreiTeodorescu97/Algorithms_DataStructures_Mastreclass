using DataStructures.Lists.Singly;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Queues
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public int Count => _list.Count;
        public bool IsEmpty => _list.Count == 0;

        public void Enqueue(T item)
        {
            _list.AddLast(item); 
        }

        public void Dequeue()
        {
            _list.RemoveFirst();
        }

        public T Peek()
        {
            return _list.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }


    }
}
