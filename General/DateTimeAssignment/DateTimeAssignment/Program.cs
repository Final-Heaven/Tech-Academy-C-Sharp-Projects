using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays current date and time
            Console.WriteLine("It is currently: " + DateTime.Now);

            // Prompts user for number to be added to time later
            Console.WriteLine("\nPlease enter a number.");
            // Converts to integer
            int number = Convert.ToInt32(Console.ReadLine());

            // Adds user input to hours of current time and displays result
            Console.WriteLine("\nIt will be " + DateTime.Now.AddHours(number) + " in {0} hours.", number);

            Console.ReadLine();
        }
    }
}
