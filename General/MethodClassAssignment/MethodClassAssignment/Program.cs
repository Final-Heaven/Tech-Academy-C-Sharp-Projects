using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Math math = new Math();

            // Using these numbers for demonstration purposes
            Console.WriteLine("The two integers are 5 and 7.");
            // Calling the method and passing in two numbers
            math.Add(5, 7);

            Console.WriteLine("\nThe two new integers are 13 and 44.");
            // Specifying parameters by name
            math.Add(userNum1: 13, userNum2: 44);

            Console.ReadLine();
        }
    }
}
