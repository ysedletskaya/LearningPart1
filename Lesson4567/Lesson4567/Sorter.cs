using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    abstract class Sorter<T> : ISorter<T> where T : IComparable<T>
    {
        protected T[] array;

        public Sorter(T[] array)
        {
            this.array = array;
            if (array.Length > 0)
                Print();
            else
                Console.WriteLine("Array is empty.");
        }

        public abstract void Sort();        

        public void Swap(ref T item1, ref T item2)
        {
            T swapTemp = item1;
            item1 = item2;
            item2 = swapTemp;
        }

        public void Print()
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine("}");
        }
    }
}
