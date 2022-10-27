using System;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            int addition = num1 + num2;
            Console.WriteLine("10 + 5 equals " + addition);
            Console.ReadLine();

            int subtraction = num1 - num2;
            Console.WriteLine("10 - 5 equals " + subtraction);
            Console.ReadLine();

            int multiplication = num1 * num2;
            Console.WriteLine("10 * 5 equals " + multiplication);
            Console.ReadLine();

            int division = num1 / num2;
            Console.WriteLine("10 / 5 equals " + division);
            Console.ReadLine();

            string string1 = "Daniel";
            string string2 = "Castillo";
            Console.WriteLine(string1 + string2);
            Console.ReadLine();
        }
    }
}
