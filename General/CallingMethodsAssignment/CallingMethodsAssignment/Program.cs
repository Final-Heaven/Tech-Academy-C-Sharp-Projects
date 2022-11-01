using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do addition on?");
            // Converts the user input to an integer and assigns it to userInput
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Calls method and reassigns userInput with updated value
            userInput = Math.Add(userInput);

            // Displays updated value to user
            Console.WriteLine("Your number + 5 = " + userInput);

            /////////////////////////////////////////////////////////

            // Additional math operations (same process as above)
            Console.WriteLine("\nPlease provide another number to do subtraction on.");
            userInput = Convert.ToInt32(Console.ReadLine());

            userInput = Math.Subtract(userInput);

            Console.WriteLine("Your number - 1 = " + userInput);

            /////////////////////////////////////////////////////////

            Console.WriteLine("\nPlease provide another number to do multiplication on.");
            userInput = Convert.ToInt32(Console.ReadLine());

            userInput = Math.Multiply(userInput);

            Console.WriteLine("Your number * 3 = " + userInput);

            Console.ReadLine();
        }
    }
}
