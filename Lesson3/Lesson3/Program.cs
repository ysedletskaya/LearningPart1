using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        public static int InputNumber(string instanceName)
        {
            Console.WriteLine("Please enter numeric value for {0}: ", instanceName);
            //Reading input number

            string input = Console.ReadLine();

            //Validation of the input
            int inputAsNumber;

            if (int.TryParse(input, out inputAsNumber))
            {
                return inputAsNumber;
            }
            Console.WriteLine("Your input is invalid");
            return 0;
        }

        public static void InputArray(ref int[] array, int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                int ArrayElement = InputNumber("Array Element #" + i.ToString());
                if (ArrayElement != 0)
                    array[i] = ArrayElement;
                else
                    i--;
            }
        }

        static void Main(string[] args)
        {
            //Entering Array size
            int arraySize = InputNumber("Array Size");

            //Entering Array elements
            int[] array = new int[] { };
            InputArray(ref array, arraySize);

            //Searching min and max of Array
            int arrayMin = int.MaxValue;
            int arrayMax = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                arrayMin = Math.Min(arrayMin, array[i]);
                arrayMax = Math.Max(arrayMax, array[i]);
            }

            //Printing Min and Max results
            Console.WriteLine("Array Minimum is: {0}", arrayMin);
            Console.WriteLine("Array Maximum is: {0}", arrayMax);
            Console.ReadKey();
        }

    }
}
