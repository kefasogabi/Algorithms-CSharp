﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    public class LinkedStack<T> : IEnumerable<T> 
    {
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return _list.Head.Value;
        }

        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _list.RemoveFirst();
        }

        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty => Count == 0;
        public int Count => _list.Count;
    }
}
