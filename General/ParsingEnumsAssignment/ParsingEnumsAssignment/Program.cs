using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");

            // Try/catch block for exception handling
            try
            {
                // Takes user input, converts it to an enum value if it matches, and stores it in a variable
                // Is also not case sensitive
                DaysOfTheWeek userInput = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                // Shows enum to verify it worked
                Console.WriteLine("Converted to enum: " + userInput);
            }
            // If an exception occurs, prompts the user to enter an actual day of the week
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
