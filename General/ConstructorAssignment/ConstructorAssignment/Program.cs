using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a const variable
            const string myString = "Jupiter";

            // Creating a variable using the keyword var
            var myNumber = 5;

            // Printing just for demonstration purposes
            Console.WriteLine("Const variable is {0} and var keyword variable is {1}", myString, myNumber);

            // Instantiating two objects, one with an argument and one without
            // Demonstrates constructor chaining
            Chain chain1 = new Chain();
            Chain chain2 = new Chain("Hello");

            // Prints to console to show it worked
            Console.WriteLine("\n" + chain1.ChainString);
            Console.WriteLine(chain2.ChainString);

            Console.ReadLine();
        }
    }
}
