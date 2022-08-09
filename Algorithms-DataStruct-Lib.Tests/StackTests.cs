﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib.Tests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new ArrayStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Pop_EmptyStack_ThrowException()
        {
            var stack = new ArrayStack<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                stack.Pop();
            });
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void Peek_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
    }

}
