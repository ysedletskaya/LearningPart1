using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    interface ISorter<T> : IPrintable
    {
        void Swap(ref T item1, ref T item2);
        
        void Sort();
    }
}
