using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating list of strings and integers to assign as property values
            List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };
            List<int> numbers = new List<int>() { 1, 2, 3 };

            // Instantiating employee objects with lists as property values of Things
            Employee<string> employee = new Employee<string>() { Things = fruits };
            Employee<int> employee1 = new Employee<int>() { Things = numbers };

            // Loop to print all fruits
            for (var i = 0; i < employee.Things.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            // Loop to print all numbers
            for (var i = 0; i < employee1.Things.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
