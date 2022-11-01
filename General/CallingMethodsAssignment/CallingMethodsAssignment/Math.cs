using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Math
    {
        // Methods take in and return an integer, and have a userInput parameter
        public static int Add(int userInput)
        {
            // Takes the userInput, does a math operation, reassigns it to new value,
            // and returns the value to Program.cs
            userInput = userInput + 5;
            return userInput;
        }

        // Same process as above
        public static int Subtract(int userInput)
        {
            userInput = userInput - 1;
            return userInput;
        }

        public static int Multiply(int userInput)
        {
            userInput = userInput * 3;
            return userInput;
        }
    }
}
