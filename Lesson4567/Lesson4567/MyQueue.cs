using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class MyQueue<T> : Buffer<T> where T : new()
    {
        public MyQueue(int bufferLength) : base(bufferLength)
        { }

        public override void Add(T value)
        {
            if (!IsFull())
            {
                bufferArray[insertPointer] = value;
                insertPointer++;
            }
            else
                Console.WriteLine("Queue is full!");
        }

        public override T Remove()
        {
            if (!IsEmpty())
            {
                T deValue = bufferArray[0];
                for (int i = 0; i < insertPointer - 1; i++)
                {
                    bufferArray[i] = bufferArray[i + 1];
                }
                bufferArray[insertPointer - 1] = default(T);
                insertPointer--;
                return deValue;
            }
            else
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
        }
    }
}
