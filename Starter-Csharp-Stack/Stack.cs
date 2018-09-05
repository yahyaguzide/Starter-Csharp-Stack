using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starter_Csharp_Stack
{
    class Stack<T>
    {
        // List's makes this program quit easy
        List<T> list = new List<T>();
       
       public void Push(T obj)
        {
            list.Add(obj);
        }
        public void Flush()
        {
            int count = list.Count;
            if (count > 0)
            {
                list.RemoveRange(0, count - 1);
            }
        }
        public T Pull()
        {
            T lastObj = list[list.Count -1];
            list.RemoveAt(list.Count -1);
            return lastObj;
        }
       
    }
}
