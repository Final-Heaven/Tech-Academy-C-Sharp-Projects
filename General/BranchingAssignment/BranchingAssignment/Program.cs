using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("\nPlease enter the package weight (in pounds): ");
            //Converts input to integer data type
            int weight = Convert.ToInt32(Console.ReadLine());

            // If weight greater than 50, informs user package is too heavy and exits the program
            // Otherwise, continues with program
            if (weight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                // This exits the program. 0 is just the status code it will return when exiting
                Environment.Exit(0);
            }

            // Taking in user inputs and converting them to integers
            Console.WriteLine("\nPlease enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // Getting total of dimensions, as well as multiplying together for later quote
            int dimensions = width + height + length;
            int quote = (width * height * length * weight) / 100;

            // If dimensions add to more than 50, inform user package is too big and exit program
            if (dimensions > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // If package isn't too big, total will be displayed from earlier calculation
            Console.WriteLine("\nEstimated total for shipping: $" + quote);
            Console.WriteLine("\nThank you!");
            Console.ReadLine();
        }
    }
}
