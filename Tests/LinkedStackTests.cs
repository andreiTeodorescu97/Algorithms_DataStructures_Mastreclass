using DataStructures.Stack;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class LinkedStackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new LinkedStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new LinkedStack<int>();
            Assert.Throws<InvalidOperationException>(() => { stack.Pop(); });
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void Peek_PushTwoItemsPop_ReturnsHeadItem()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
    }
}
