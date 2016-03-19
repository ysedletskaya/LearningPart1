using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class MyStack<T> : Buffer<T> where T : new()
    {

        public MyStack(int bufferLength) : base(bufferLength)
        { }

        public override T Remove()
        {
            if (!IsEmpty())
            {
                T popedValue = bufferArray[insertPointer - 1];
                bufferArray[insertPointer - 1] = default(T);
                insertPointer--;
                return popedValue;
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
             }
        }

        public override void Add(T value)
        {
            if (!IsFull())
            {
                bufferArray[insertPointer] = value;
                insertPointer++;
            }
            else
                Console.WriteLine("Stack is full!");
        }

        public T Peek()
        {            
            if (!IsEmpty())
            {
                return bufferArray[insertPointer - 1];
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
        }
     }
}
