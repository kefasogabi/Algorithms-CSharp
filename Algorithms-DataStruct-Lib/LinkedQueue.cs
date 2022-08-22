﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    public class LinkedQueue<T> : IEnumerable<T>
    {

        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();

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
            if (IsEmpty)
                throw new InvalidOperationException();

            return _list.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _list.Count;
        public bool IsEmpty => Count == 0;


    }
}
