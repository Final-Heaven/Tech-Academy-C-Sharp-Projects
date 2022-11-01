using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Math math = new Math();

            Console.WriteLine("Please input a number: ");
            // Converting first number to integer
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease input a second number:\n" +
                "(This part is optional. If you leave this part blank, a default number (5) will be used.)");
            // Keeping this as a string to check if it's empty
            string userEntry = Console.ReadLine();

            // If the user didn't input anything, pass in the first number and use the default second number
            if (userEntry == "")
            {
                Console.WriteLine("\nAdding the two numbers...\nThe result is " + math.Add(userNum1));
            }
            // If the user did input a second number, pass them both in
            else
            {
                int userNum2 = Convert.ToInt32(userEntry);
                Console.WriteLine("\nAdding the two numbers...\nThe result is " + math.Add(userNum1, userNum2));
            }

            Console.ReadLine();
        }
    }
}
