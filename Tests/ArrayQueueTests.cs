using DataStructures.Queues;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ArrayQueueTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new ArrayQueue<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_EnqueueOneItem_ReturnsOne()
        {
            var stack = new ArrayQueue<int>();
            stack.Enqueue(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void DEnqueue_EmptyStack_ThrowsException()
        {
            var stack = new ArrayQueue<int>();
            Assert.Throws<InvalidOperationException>(() => { stack.Dequeue(); });
        }

        [Test]
        public void Peek_EnqueueTwoItems_ReturnsHeadItem()
        {
            var stack = new ArrayQueue<int>();
            stack.Enqueue(1);
            stack.Enqueue(2);

            Assert.AreEqual(1, stack.Peek());
        }

        [Test]
        public void Peek_EnqueueTwoItemsDEnqueue_ReturnsHeadItem()
        {
            var stack = new ArrayQueue<int>();
            stack.Enqueue(1);
            stack.Enqueue(2);
            stack.Dequeue();

            Assert.AreEqual(2, stack.Peek());
        }
    }
}
