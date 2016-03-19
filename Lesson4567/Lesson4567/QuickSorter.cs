using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class QuickSorter<T> : Sorter <T> where T : IComparable<T>
    {
        public QuickSorter (T[] array) : base(array)
        { }

        protected int Partition(T[] array, int left, int right)
        {
            T pivotValue = array[left];
            int pivot = left;
            while (left < right)
            {
                while (pivotValue.CompareTo(array[left]) >= 0)
                {
                    if (left < array.Length - 1)
                        left++;
                    else
                        break;
                }

                while (pivotValue.CompareTo(array[right]) < 0)
                {
                    if (right > 0)
                        right--;
                    else
                        break;
                }

                if (left < right)
                {
                    if (pivot == left)
                        pivot = right;
                    else
                        if (pivot == right)
                            pivot = left;
                    Swap(ref array[right], ref array[left]);                    
                }
            }
            Swap(ref array[pivot], ref array[right]);
            return right;
        }

        protected void QuickSortRecursive(T[] array, int left, int right)
        {       
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                    QuickSortRecursive(array, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSortRecursive(array, pivot + 1, right);
            }
        }
       
        public override void Sort()
        {
            QuickSortRecursive(array, 0, array.Length - 1);
        }
    }
}
