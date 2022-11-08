using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try/catch block
            try
            {
                // Prompts user for their age
                Console.WriteLine("Please enter your age.");
                // Converts to an integer
                int age = Convert.ToInt32(Console.ReadLine());
                // If the user inputs 0 or a negative number, throws custom exception
                if (age <= 0)
                {
                    throw new InvalidAgeException();
                }
                // If no exceptions occurred, displays year user was born using datetime year minus their age
                Console.WriteLine("You were born in the year " + (DateTime.Now.Year - age) + ".");
            }
            // Custom exception name
            // Specifically informs users their input was not valid
            catch (InvalidAgeException)
            {
                Console.WriteLine("You entered an invalid age.");
            }
            // All other exceptions are caught here
            // A generic error message is displayed
            catch (Exception)
            {
                Console.WriteLine("There was an unidentified error.");
            }

            Console.Read();
        }
    }
}
