using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title of program
            Console.WriteLine("Car Insurance Approval Program\n");

            Console.WriteLine("What is your age?");
            // Stores input in integer data type
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (Please enter true or false)");
            // Stores input in boolean data type for comparison later
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            // Stores input in integer data type
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you qualified for insurance?");
            // All three conditions must be met for the user to be qualified
            Console.WriteLine(age > 15 && hasDUI == false && tickets <= 3);
            Console.ReadLine();
        }
    }
}
