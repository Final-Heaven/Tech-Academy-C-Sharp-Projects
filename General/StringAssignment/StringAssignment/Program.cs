using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating three variables of string data type
            string string1 = "Hello, ";
            string string2 = "my name is ";
            string string3 = "Daniel.";

            // Concatenating the three strings together and displaying them
            Console.WriteLine(string1 + string2 + string3);
            Console.ReadLine();

            string lower = "this was lowercase.";

            // Converts string to all uppercase
            Console.WriteLine(lower.ToUpper());
            Console.ReadLine();

            // StringBuilder allows for modification of strings
            StringBuilder build = new StringBuilder();

            // Adding on new strings using StringBuilder
            build.Append("This is from StringBuilder.");
            build.Append("\nI am appending to it.");
            build.Append("\nIt is working as intended.");
            build.Append("\nGood stuff!");

            // Displays full string
            Console.WriteLine(build);
            Console.ReadLine();
        }
    }
}
