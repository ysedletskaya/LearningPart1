using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4567
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;
            
            Console.WriteLine("Bubble Sorting:");
            array = FillArrayWithRandomValues(10, 0, 100);
            BubbleSorter<int> bubbleSorter1 = new BubbleSorter<int>(array);
            bubbleSorter1.Sort();
            bubbleSorter1.Print();

            string[] strArray = { "orange", "grape", "apple", "peach", "banana", "water-melon", "apricot" };
            BubbleSorter<string> bubbleSorter2 = new BubbleSorter<string>(strArray);
            bubbleSorter2.Sort();
            bubbleSorter2.Print();

            Console.WriteLine("Insert Sorting:");
            array = FillArrayWithRandomValues(10, 0, 100);
            InsertionSorter<int> inserterSorter1 = new InsertionSorter<int>(array);
            inserterSorter1.Sort();
            inserterSorter1.Print();

            string[] strArray2 = { "yulia", "mykola", "alex", "leonid", "vadym", "vova", "roman" };
            InsertionSorter<string> insertionSorter2 = new InsertionSorter<string>(strArray2);
            insertionSorter2.Sort();
            insertionSorter2.Print();

            Console.WriteLine("Quick Sorting:");
            double[] arrayQS = {56.87, 34.986, 2.6, 785.8, 24.9, 243.54, 9.463, 29.7};
            QuickSorter<double> quickSorter1 = new QuickSorter<double>(arrayQS);
            quickSorter1.Sort();
            quickSorter1.Print();

            int[] arrayQS2 = FillArrayWithRandomValues(15, 0, 100);
            QuickSorter<int> quickSorter2 = new QuickSorter<int>(arrayQS2);
            quickSorter2.Sort();
            quickSorter2.Print();

            MyStack<int> testStack = new MyStack<int>(10);
            Console.WriteLine("Pushing into the stack 1 to 11:");
            for (int i = 1; i < 12; i++)
            {
                testStack.Add(i);
                testStack.Print();
            }

            Console.WriteLine("Peeking and poping from the stack 11 times:");
            for (int i = 0; i < 11; i++)
            {
                testStack.Peek();
                testStack.Remove();
                testStack.Print();
            }

            MyQueue<int> testQueue = new MyQueue<int>(10);
            Console.WriteLine("Entering to queue 1 to 11:");
            for (int i = 1; i < 12; i++)
            {
                testQueue.Add(i);
                testQueue.Print();
            }

            Console.WriteLine("Deleting from queue 11 times:");
            for (int i = 0; i < 11; i++)
            {
                testQueue.Remove();
                testQueue.Print();
            }

            CircularBufferQueue<int> testRingQueue = new CircularBufferQueue<int>(10, 5);
            Console.WriteLine("Entering into ring buffer 1 to 11 from start point 5");
            for (int i = 1; i < 12; i++)
            {
                testRingQueue.Add(i);
                testRingQueue.Print();
            }
            Console.WriteLine("Deleting from ring buffer 11 times");
            for (int i = 0; i < 11; i++)
            {
                testRingQueue.Remove();
                testRingQueue.Print();
            }        

            CircularBufferQueue<char> testRingQueueChar = new CircularBufferQueue<char>(10, 3);
            Console.WriteLine("Entering into ring buffer A to O from start point 3");
            for (int i = 1; i < 16; i++)
            {
                testRingQueueChar.Add((char)(64+i));
                testRingQueueChar.Print();
            }
            Console.WriteLine("Deleting from ring buffer 11 times");
            for (int i = 0; i < 11; i++)
            {
                testRingQueueChar.Remove();
                testRingQueueChar.Print();
            }
        }


        static public int[] FillArrayWithRandomValues(int arrayLength, int randomMin, int randomMax)
        {
            int[] array = new int[arrayLength];
            Random getRandom = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = getRandom.Next(randomMin, randomMax);
            }
            return array;
        }
    }
}