using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class InsertionSorter<T> : Sorter<T> where T : IComparable<T>
    {
        public InsertionSorter (T[] array) : base(array)
        { }

        public override void Sort()
        {
            for (int j = array.Length; j > 0; j--)
                for (int i = 1; i < j; i++)
                {
                    if (array[i].CompareTo(array[i - 1]) < 0)
                    {
                        Swap(ref array[i], ref array[i - 1]);
                    }
                }
        }
    }
}
