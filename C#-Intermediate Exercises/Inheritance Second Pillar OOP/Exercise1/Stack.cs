using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace Exercise1
{
    public class Stack
    {
        private object _obj { get; set; }
        private int _i { get; set; }
        private ArrayList list = new ArrayList();

        public Stack()
        {
            _i = 0;
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Object cant be null");
            } 
            else
            {
                list.Add(obj);
            }

        }
        public object Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty stack, add an object");
            }
            else
            {
                int lastIndex = list.Count - 1;
                object firstObject = list[lastIndex];
                list.RemoveAt(lastIndex);
                return firstObject;
            }
        }
        public void Clear()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty stack, add an object");
            }
            else
            {
                list.Clear();
            }

        }
    }
}
