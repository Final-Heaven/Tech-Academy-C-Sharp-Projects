using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating object and assigning amount
            Number number = new Number() { Amount = 55.57M };

            // Printing amount to console
            Console.WriteLine(number.Amount);

            Console.ReadLine();
        }
    }
}
