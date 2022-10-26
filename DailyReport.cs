using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   
            // \n Creates new lines
            // The program stores all user inputs in variables
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n");

            // Console.ReadLine() takes user input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // User input is a string, but is then converted to byte
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            byte pageNumber = (byte)Convert.ToInt32(page);

            // User input is a string, but is then converted to a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // User input is a string, but is then converted to a byte
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            byte hoursStudied = (byte)Convert.ToInt32(hours);

            // Final Console.ReadLine() prevents program from immediately closing
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
