using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataStructures.Lists.Doubly
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            Node<T> tmp = Head;
            Head = node;

            //shifting the formal Head
            Head.Next = tmp;

            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                tmp.Previous = Head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (Count == 0)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;
            Count--;

            if (Count == 0)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }

            Count--;
        }
    }
}
