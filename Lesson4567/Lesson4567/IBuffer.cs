using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    interface IBuffer<T> : IPrintable where T : new()
    {
        bool IsEmpty();

        bool IsFull();
    }
}
