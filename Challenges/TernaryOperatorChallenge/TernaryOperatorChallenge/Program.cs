using System;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            string result = x > y ? "X is greater than Y" : "X is not greater than Y";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
