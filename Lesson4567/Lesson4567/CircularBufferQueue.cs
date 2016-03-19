using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class CircularBufferQueue<T> : Buffer<T> where T : new()
    {
        private int startPointer = 0;
        private int bufferDataAmount = 0;

        public CircularBufferQueue(int bufferLength, int startPointer)
            : base(bufferLength)
        {
            if (startPointer < bufferLength)
            {
                this.startPointer = startPointer;
                this.insertPointer = startPointer;
                this.bufferDataAmount = 0;
            }
            else
                Console.WriteLine("Wrong buffer start poiner was specified.");
        }

        public override void Add(T value)
        {
            insertPointer = CheckPointer(insertPointer);
            if (IsFull())
            {
                Console.WriteLine("Queue is full - overwriting queue head.");
                startPointer++;
                bufferDataAmount--;
            }
            bufferArray[insertPointer] = value;
            insertPointer++;
            bufferDataAmount++;
        }

        public override T Remove()
        {
            T deValue = bufferArray[startPointer];
            bufferArray[startPointer] = default(T);
            if (!IsEmpty())
            {
                bufferDataAmount--;
                startPointer++;
            }
            else
                Console.WriteLine("Queue is empty!");
            startPointer = CheckPointer(startPointer);
            return deValue;
        }

        public override bool IsEmpty()
        {
            if (bufferDataAmount == 0)
                return true;
            else
                return false;
        }

        public override bool IsFull()
        {
            if (bufferDataAmount == bufferLength)
                return true;
            else
                return false;
        }

        private int CheckPointer(int pointer)
        {
            if (pointer == bufferLength)
            {
                pointer = 0;
            }
            return pointer;
        }
    }
}
