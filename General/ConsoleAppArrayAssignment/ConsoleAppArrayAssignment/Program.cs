using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating array of strings
            string[] stringArray = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            Console.WriteLine("String Array");
            Console.WriteLine("Please select an array index: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            // If user selects index outside of range, set boolean to true and enter while loop
            bool isOutsideRange = stringIndex > 9;

            while (isOutsideRange)
            {
                Console.WriteLine("That index does not exist. Please select a number from 0 to 9.");
                Console.WriteLine("Please select an array index: ");
                stringIndex = Convert.ToInt32(Console.ReadLine());
                // Loop keeps repeating until user enters a valid index
                if (stringIndex >= 0 && stringIndex <= 9)
                {
                    isOutsideRange = false;
                }
            }

            // Gets value of index and displays it to the user
            Console.WriteLine("\nThe string at that index is: " + stringArray[stringIndex]);

            ///////////////////////////////////////////////////////////////////////////////////

            // Creating array of integers
            int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("\nInteger Array");
            Console.WriteLine("Please select an array index: ");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            // Same idea as above
            bool isOutsideRange1 = intIndex > 9;

            while (isOutsideRange1)
            {
                Console.WriteLine("That index does not exist. Please select a number from 0 to 9.");
                Console.WriteLine("Please select an array index: ");
                intIndex = Convert.ToInt32(Console.ReadLine());
                if (intIndex >= 0 && intIndex <= 9)
                {
                    isOutsideRange1 = false;
                }
            }

            // Gets value of index and displays it to the user
            Console.WriteLine("\nThe integer at that index is: " + intArray[intIndex]);

            ///////////////////////////////////////////////////////////////////////////////////

            // Creating list of strings
            List<string> stringList = new List<string>();
            // Adding strings to list
            stringList.Add("The");
            stringList.Add("quick");
            stringList.Add("brown");
            stringList.Add("fox");

            Console.WriteLine("String List");
            Console.WriteLine("Please select a list index: ");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            // Same idea as above
            bool isOutsideRange2 = listIndex > 3;

            while (isOutsideRange2)
            {
                Console.WriteLine("That index does not exist. Please select a number from 0 to 3.");
                Console.WriteLine("Please select a list index: ");
                listIndex = Convert.ToInt32(Console.ReadLine());
                if (listIndex >= 0 && listIndex <= 3)
                {
                    isOutsideRange2 = false;
                }
            }

            // Gets value of index and displays it to the user
            Console.WriteLine("\nThe string at that index is: " + stringList[listIndex]);

            Console.ReadLine();
        }
    }
}
