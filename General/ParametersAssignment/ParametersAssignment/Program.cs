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
            //List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };

            //Employee<string> employee = new Employee<string>() { Things = fruits };

            //List<int> numbers = new List<int>() { 1, 2, 3 };

            //Employee<int> employee1 = new Employee<int>() { Things = numbers };

            //for (var i = 0; i < employee.Things.Count; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //for (var i = 0; i < employee1.Things.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.ReadLine();

            Employee<string> employee = new Employee<string>();

            employee.Things.Add("Apple");
        }
    }
}
