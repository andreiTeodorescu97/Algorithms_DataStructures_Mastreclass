using DataStructures.Lists.Singly;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class SinglyLinkedListTests
    {
        private SinglyLinkedList<int> _list;

        [SetUp]
        public void Init()
        {
            _list = new SinglyLinkedList<int>();
        }

        [Test]
        public void CreateEmptyList_CorrectState()
        {
            Assert.IsTrue(_list.Count == 0);
            Assert.IsTrue(_list.Head == null);
            Assert.IsTrue(_list.Tail == null);
        }

        [Test]
        public void AddFirst_and_AddLast_OneItem_CorrectState()
        {
            _list.AddFirst(1);
            CheckStateWithSingleNode();

            _list.RemoveFirst();

            _list.AddLast(1);
            CheckStateWithSingleNode();

        }

        private void CheckStateWithSingleNode()
        {
            Assert.IsTrue(_list.Count == 1);
            Assert.AreSame(_list.Tail, _list.Head);
        }

        [Test]
        public void ComplexTest()
        {
            _list.AddFirst(1);
            _list.AddLast(2);
            _list.RemoveFirst();

            CheckStateWithSingleNode();

            _list.AddFirst(2);
            _list.RemoveLast();

            CheckStateWithSingleNode();
        }

        [Test]
        public void CheckOrderOfItems()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);

            Assert.AreEqual(2, _list.Head.Value);
            Assert.AreEqual(1, _list.Tail.Value);

            _list.AddLast(3);
            Assert.AreEqual(3, _list.Tail.Value);

            _list.AddFirst(99);
            Assert.AreEqual(99, _list.Head.Value);
        }

        [Test]
        public void RemoveFirst_EmptyList()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveFirst());
        }

        [Test]
        public void RemoveLast_EmptyList()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveLast());
        }

        [Test]
        public void Remove_CorrectState()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);
            _list.AddFirst(3);
            _list.AddFirst(4);

            _list.RemoveFirst();
            _list.RemoveLast();

            Assert.AreEqual(3, _list.Head.Value);
            Assert.AreEqual(2, _list.Tail.Value);
        }
    }
}
