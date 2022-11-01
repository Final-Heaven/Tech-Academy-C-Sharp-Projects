using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Math math = new Math();

            Console.WriteLine("Please input a number to be divided by 2.");
            // Converts user input to integer and calls method
            int number = Convert.ToInt32(Console.ReadLine());
            math.Divide(number);

            Console.ReadLine();

            // Method will display the result of an output parameter
            Math.Output(3, out int outNumber);
            Console.WriteLine("Moving on...");
            Console.WriteLine("Result of output parameter: " + outNumber);

            Console.ReadLine();

            Console.WriteLine("Input a number: ");
            // Converts user input to integer
            int input = Convert.ToInt32(Console.ReadLine());

            // Calls method
            Console.WriteLine("Your number + 8 = " + Math.Add(input));

            Console.ReadLine();

            // Will take two user numbers and add them together
            Console.WriteLine("Input the first number to be added: ");
            int add1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to be added: ");
            int add2 = Convert.ToInt32(Console.ReadLine());

            // Method name is the same as above
            // Example of method overloading
            Console.WriteLine("{0} + {1} = {2}", add1, add2, Math.Add(add1, add2));

            Console.ReadLine();

            // The below utilizes a method of a static class
            Console.WriteLine("I have now created a static class...");
            Console.WriteLine("Input the first number to be multiplied: ");
            int multiply1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to be multiplied: ");
            int multiply2 = Convert.ToInt32(Console.ReadLine());

            // Multiplies user numbers together
            int result = Static.Multiply(multiply1, multiply2);

            Console.WriteLine("The result of the multiplication is " + result);

            Console.ReadLine();
        }
    }
}
