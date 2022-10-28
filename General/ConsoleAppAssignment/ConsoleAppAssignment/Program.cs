using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color: ");
            // User input is stored as string data type
            string color = Console.ReadLine();
            // Boolean is always set to false at first to ensure the loop runs at least once
            bool isGuessed = false;

            // While isGuessed is false, the loop will run
            while (!isGuessed)
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("Red is incorrect. Try again.\n");
                        Console.WriteLine("Guess my favorite color: ");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("Yellow is incorrect. Try again.\n");
                        Console.WriteLine("Guess my favorite color: ");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("Purple is incorrect. Try again.\n");
                        Console.WriteLine("Guess my favorite color: ");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("Green is incorrect. Try again.\n");
                        Console.WriteLine("Guess my favorite color: ");
                        color = Console.ReadLine();
                        break;
                    // The correct choice, blue, will set isGuessed to true
                    // As a result, the loop will end and the program will continue
                    case "blue":
                        Console.WriteLine("Blue is correct! Nice job! Continuing on...");
                        isGuessed = true;
                        break;
                    // Default happens if none of the above cases happen
                    default:
                        Console.WriteLine("That is incorrect. Try again.\n");
                        Console.WriteLine("Guess my favorite color: ");
                        color = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();

            // Next part of program
            Console.WriteLine("Guess my age: ");
            // Stores user input as integer data type
            int age = Convert.ToInt32(Console.ReadLine());
            // Here, the boolean can be true or false at first depending on user input
            bool ageGuessed = age == 22;

            // Since it's possible the boolean may already be true, use a do while loop
            // instead to ensure the loop happens at least once
            do
            {
                switch (age)
                {
                    case 18:
                        Console.WriteLine("18 is incorrect. Try again.\n");
                        Console.WriteLine("Guess my age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("20 is incorrect. Try again.\n");
                        Console.WriteLine("Guess my age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("100 is incorrect. Try again.\n");
                        Console.WriteLine("Guess my age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 75:
                        Console.WriteLine("75 is incorrect. Try again.\n");
                        Console.WriteLine("Guess my age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        // The correct choice, 22, will set ageGuessed to true
                        // As a result, the loop will end
                        Console.WriteLine("22 is correct! Nice job!");
                        ageGuessed = true;
                        break;
                    // Default happens if none of the above cases happen
                    default:
                        Console.WriteLine("That is incorrect. Try again.\n");
                        Console.WriteLine("Guess my age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // The loop will always happen at least once, and will
            // continue as long as ageGuessed is false
            while (!ageGuessed);

            Console.ReadLine();
        }
    }
}
