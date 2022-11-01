using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Math
    {
        // Takes two integers as parameters
        public void Add(int userNum1, int userNum2)
        {
            // Does math operation on the first number
            int result = userNum1 + 10;
            Console.WriteLine("First number + 10 = " + result);
            // Displays second number as is
            Console.WriteLine("Here is the second number: " + userNum2);
            return;
        }
    }
}
