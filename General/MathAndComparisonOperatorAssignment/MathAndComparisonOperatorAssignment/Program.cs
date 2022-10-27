using System;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter Person 1's hourly rate: ");
            // Stores rate input as double to allow proper conversions and calculations
            double person1rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Person 1's hours worked per week: ");
            int person1hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Please enter Person 2's hourly rate: ");
            double person2rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Person 2's hours worked per week: ");
            int person2hours = Convert.ToInt32(Console.ReadLine());

            // Multiplies hourly rate by hours worked per week by number of weeks in a year
            // Assigns it to double data type to account for decimal places
            double person1annual = (person1rate * person1hours * 52);
            double person2annual = (person2rate * person2hours * 52);

            // Simple comparison - does person 1 have a higher annual salary?
            // Utilizes bool data type
            bool moreMoney = person1annual > person2annual;

            // Prints annual salaries
            Console.WriteLine("\nAnnual salary of Person 1:\n$" + person1annual);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2:\n$" + person2annual);
            Console.ReadLine();

            // Displays result of annual salary comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(moreMoney);
            Console.ReadLine();
        }
    }
}
