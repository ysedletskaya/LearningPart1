using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    abstract class Buffer<T> : IBuffer<T> where T : new()
    {
        protected int bufferLength = 0;
        protected T[] bufferArray = null;
        protected int insertPointer = 0;

        public Buffer(int bufferLength)
        {
            if (bufferLength > 0)
            {
                this.bufferLength = bufferLength;
                this.bufferArray = new T[bufferLength];
                this.insertPointer = 0;
            }
            else
                Console.WriteLine("Wrong Buffer lengh was specified.");
        }

        public virtual bool IsEmpty()
        {
            if (insertPointer == 0)
                return true;
            else
                return false;
        }

        public virtual bool IsFull()
        {
            if (insertPointer == bufferLength)
                return true;
            else
                return false;
        }

        abstract public void Add(T value);

        abstract public T Remove();

        public void Print()
        {
            Console.Write("{");
            for (int i = 0; i < bufferArray.Length; i++)
            {
                Console.Write(" {0} ", bufferArray[i]);
            }
            Console.WriteLine("}");
        }
    }
}
