using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class BubbleSorter<T> : Sorter<T> where T : IComparable<T>
    { 
        public BubbleSorter (T[] array) : base(array)
        { }
       
        public override void Sort()
        {
            for (int j = 0; j < array.Length - 1; j++)
                for (int i = 0; i < array.Length - j - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
        }
    }
}
