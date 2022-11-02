using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Math
    {
        // Void method that outputs an integer
        public void Divide(int number)
        {
            // Divides user input by 2 and displays it
            Console.WriteLine("Your number / 2 = " + number / 2);
            return;
        }

        // Method with output parameter
        public static int Output(int number, out int outNumber)
        {
            outNumber = 5;
            int result = number + 5;
            return result;
        }

        ////////////////////////////////////////////////////////////////
        // Method overloading

        // This takes one parameter
        public static int Add(int number)
        {
            return number + 8;
        }

        // This takes two parameters
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
