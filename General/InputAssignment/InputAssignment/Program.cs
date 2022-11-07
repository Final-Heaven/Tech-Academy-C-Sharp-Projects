using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input a number
            Console.WriteLine("Please enter a number.");
            // Converts user input to an integer
            int number = Convert.ToInt32(Console.ReadLine());
            // Creates new text file at specified location and writes user input to it
            using (StreamWriter file = new StreamWriter(@"C:\Users\admin\Logs\InputAssignment.txt", true))
            {
                file.WriteLine(number);
            }

            // Reads text file and displays the number that was logged
            string text = File.ReadAllText(@"C:\Users\admin\Logs\InputAssignment.txt");
            Console.WriteLine("The logs show you typed the number: {0}", text); ;

            Console.ReadLine();
        }
    }
}
