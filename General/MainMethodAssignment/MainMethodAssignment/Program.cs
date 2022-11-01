using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Math math1 = new Math();
            Console.WriteLine("Please input an integer: ");
            // Converting user input to an integer
            int userInput = Convert.ToInt32(Console.ReadLine());
            // Calling method and displaying result
            Console.WriteLine("Your number + 10 = " + math1.Add(userInput));

            Console.ReadLine();

            /////////////////////////////////////////////////////////////

            Math math2 = new Math();
            Console.WriteLine("Please input a decimal: ");
            // Converting user input to a double(decimal)
            double userInput2 = Convert.ToDouble(Console.ReadLine());
            // Calling method and displaying result
            Console.WriteLine("Your number + 5 = " + math2.Add(userInput2));

            Console.ReadLine();

            /////////////////////////////////////////////////////////////

            Math math3 = new Math();
            Console.WriteLine("Please input a number: ");
            // Keeping user input as a string
            // Conversion is done when the method is called
            string userInput3 = Console.ReadLine();
            // Calling method and displaying result
            Console.Write("Your number + 12 = " + math3.Add(userInput3));

            Console.ReadLine();
        }
    }
}
