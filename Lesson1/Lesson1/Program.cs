using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        public static int InputNumber(string a)
        {
            Console.WriteLine("Please enter {0}:", a);
            //Reading input number
            
            string input = Console.ReadLine();

            int inputAsNumber;
            
            if (int.TryParse(input, out inputAsNumber))
            {
                return inputAsNumber;
            }
            Console.WriteLine("You entered an invalid number");
            return 0;
        }

        private static void Main(string[] args)
        {
            int numberA = InputNumber("A");
            int numberB = InputNumber("B");
            if (numberA%numberB == 0)
            {
                Console.WriteLine("B is divider of A");
            }
            else
            {
                Console.WriteLine("B is NOT diveder of A");
            }
            Console.ReadKey();
        }
    }
}
