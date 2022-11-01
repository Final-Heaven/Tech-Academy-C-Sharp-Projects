using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Math
    {
        // Second parameter is optional with a default value of 5
        public int Add(int number1, int number2 = 5)
        {
            // Adds both numbers together and returns the result
            int result = number1 + number2;
            return result;
        }
    }
}
