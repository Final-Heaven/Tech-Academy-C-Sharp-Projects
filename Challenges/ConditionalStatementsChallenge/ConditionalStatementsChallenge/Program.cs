using System;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            if (x > 10)
            {
                Console.WriteLine("X is greater than 10");
            }
            else if (x < 10)
            {
                Console.WriteLine("X is less than 10");
            }
            else
            {
                Console.WriteLine("X is equal to 10");
            }
            Console.ReadLine();
        }
    }
}
