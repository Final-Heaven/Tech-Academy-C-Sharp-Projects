using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1

            //Creating array of strings
            string[] stringArray = { "First: ", "Second: ", "Third: ", "Fourth: ", "Fifth: " };

            // Asks for user input
            Console.WriteLine("Please input text to be added to each string: ");
            string input = Console.ReadLine();

            // Adds user's text input to the end of each string
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + input;
            }

            // Prints off each string in the array to console
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////
            // Part 2

            //Creating infinite loop by having condition always be true

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Fixing infinite loop by giving it a stopping point
            // In this case, stops at 5
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////
            // Part 3

            // Loop with  "<" for comparison
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            // Loop with "<=" for comparison
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////
            // Part 4

            // Creating list of strings
            List<string> colors = new List<string> { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            Console.WriteLine("Please input text to search for in the list of colors: ");
            // Sets user input to lowercase in order to easily match list items
            string listInput = Console.ReadLine().ToLower();
            // Setting boolean to false in order to ensure proper while loop
            bool isPresent = false;

            // While loop continues until match is found
            while (!isPresent)
            {
                foreach (string color in colors)
                {
                    if (color.Contains(listInput))
                    {
                        Console.WriteLine("\nMatching text is found at index: " + colors.IndexOf(color));
                        // Ends while loop
                        isPresent = true;
                        // Ends foreach loop
                        break;
                    }
                    else
                    {
                        // This ensures the message only appears once the entire list has been iterated through
                        if (colors.IndexOf(color) == 6)
                        {
                            Console.WriteLine("\nNo matching text is found in the list. Please try again.");
                            Console.WriteLine("\nPlease input text to search for in the list of colors: ");
                            // Takes in new input, after which the while loop restarts
                            listInput = Console.ReadLine().ToLower();
                        }
                    }
                }
            }

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////
            // Part 5

            List<string> fruits = new List<string> { "apple", "banana", "grape", "orange", "strawberry", "banana", "mango" };

            Console.WriteLine("\nPlease input text to search for in the list of fruits: ");
            string fruitInput = Console.ReadLine().ToLower();
            bool fruitPresent = false;

            while (!fruitPresent)
            {
                // Using for loop to more easily track indices of duplicate items
                for (var i = 0; i < fruits.Count; i++)
                {
                    if (fruits[i].Contains(fruitInput))
                    {
                        Console.WriteLine("\nMatching text is found at index: " + i);
                        fruitPresent = true;
                    }
                    else
                    {
                        // Returns no match if on last iteration and fruitPresent is false,
                        // since if a match was made fruitPresent would be true
                        if (i == 6 && fruitPresent == false)
                        {
                            Console.WriteLine("\nNo matching text is found in the list.");
                            fruitPresent = true;
                        }
                    }
                }
            }

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////
            // Part 6

            // Creating actual list to be checked
            List<string> letters = new List<string> { "A", "B", "C", "D", "B" };
            // Creating empty list to add letters to later
            List<string> emptyList = new List<string>();

            foreach (string letter in letters)
            {
                // Checks emptyList - if it doesn't contain the current letter being
                // checked, it's unique
                if (!emptyList.Contains(letter))
                {
                    Console.WriteLine(letter + " = This item is unique.");
                    // Adds the letter to emptyList because if it appears again it
                    // will no longer be unique
                    emptyList.Add(letter);
                }
                else if (emptyList.Contains(letter))
                {
                    Console.WriteLine(letter + " - This item is not unique.");
                }
            }

            Console.ReadLine();

        }
    }
}
