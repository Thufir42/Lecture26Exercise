using System;
using System.Collections;

namespace Lecture26Exercise
{
    public class Stack
    {
        private ArrayList _stackList = new ArrayList();

        public int GetStackCount() => _stackList.Count;

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null object can not be added");

            _stackList.Add(obj);
        }

        public object Pop()
        {
            if (_stackList.Count < 1)
                throw new InvalidOperationException("Can not remove from an empty list");

            var _topitem = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return _topitem;
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}