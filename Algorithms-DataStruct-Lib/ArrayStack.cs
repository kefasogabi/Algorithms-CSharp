using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    public class ArrayStack<T>
    {
        public bool IsEmpty { get; set; }
        public int Count { get; set; }

        private T[] _items;

        public ArrayStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public void Push(T p0)
        {
            throw new NotImplementedException();
        }

        public double Peek()
        {
            throw new NotImplementedException();
        }

        public void Pop()
        {
            throw new NotImplementedException();
        }
    }
}
