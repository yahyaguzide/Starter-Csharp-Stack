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
       
       void Push(T obj)
        {
            list.Add(obj);
        }
        void Flush()
        {
            list.RemoveRange(0, list.Count);
        }
        T Get(int index)
        {
            return list[index];
        }
       
    }
}
