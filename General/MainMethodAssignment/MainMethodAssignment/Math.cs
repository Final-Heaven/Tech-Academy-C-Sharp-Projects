using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        // Takes in an integer and returns an integer
        public int Add(int number)
        {
            number = number + 10;
            return number;
        }

        // Takes in a double(decimal) and returns an integer
        // This will result in rounding
        public int Add(double number2)
        {
            number2 = number2 + 5;
            return Convert.ToInt32(number2);
        }

        // Takes in a string and returns an integer
        // Will only work if conversion is possible
        public int Add(string text)
        {
            int convert = Convert.ToInt32(text);
            return convert + 12;
        }
    }
}
