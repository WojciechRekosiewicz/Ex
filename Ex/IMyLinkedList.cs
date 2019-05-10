using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    interface IMyLinkedList<T>
    {
        int Count();

        void AddLast(T data);

    }
}
