using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try block
            try
            {
                // Creating new list of integers
                List<int> numbers = new List<int> { 1, 3, 5, 10, 20, 100 };

                Console.WriteLine("Please enter a number: ");
                // userInput is decimal for accurate calculations
                decimal userInput = Convert.ToDecimal(Console.ReadLine());

                // Loops through list and divides the numbers by the user's number
                foreach (int number in numbers)
                {
                    Console.WriteLine(number + " / " + userInput + " = " + (number / userInput));
                }
                Console.ReadLine();
            }
            // String inputs will be caught with this block
            catch (FormatException format)
            {
                Console.WriteLine(format.Message);
            }
            // If the user tries to input 0, it will be caught here
            catch (DivideByZeroException zero)
            {
                Console.WriteLine(zero.Message);
            }
            // Finally block will run regardless of previous outcome
            finally
            {
                Console.WriteLine("\nThe program has emerged from the try/catch block.\nContinuing with program execution...");
                Console.ReadLine();
            }
        }
    }
}
