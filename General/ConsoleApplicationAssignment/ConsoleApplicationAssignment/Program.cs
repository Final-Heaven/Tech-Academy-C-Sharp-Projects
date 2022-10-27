using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program takes user inputs and performs various math operations/comparisons
            Console.WriteLine("Number to be multiplied by 50: ");
            // Need to convert user input (string) into an integer for math operations
            int usermultiply = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour number multiplied by 50 is: " + (usermultiply * 50));
            Console.ReadLine();

            Console.WriteLine("Number to add 25 to: ");
            int useradd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour number plus 25 is: " + (useradd + 25));
            Console.ReadLine();

            Console.WriteLine("Number to divide by 12.5: ");
            // Convert string to a double here to allow for decimal places
            double userdivide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nYour number divided by 12.5 is: " + (userdivide / 12.5));
            Console.ReadLine();

            // Converts string to integer and then does comparison
            Console.WriteLine("Number to check if greater than 50: ");
            bool usergreater = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("\nIs your number greater than 50: " + usergreater);
            Console.ReadLine();

            Console.WriteLine("Number to check remainder of dividing by 7: ");
            int userremainder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe remainder is: " + (userremainder % 7));
            Console.ReadLine();
        }
    }
}
