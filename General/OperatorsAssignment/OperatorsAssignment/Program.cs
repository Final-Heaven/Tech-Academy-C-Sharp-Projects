using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating three employee objects for demonstration purposes
            // They each have different Id values
            Employee employeeA = new Employee() { Id = 1 };
            Employee employeeB = new Employee() { Id = 2 };
            Employee employeeC = new Employee() { Id = 3 };

            // Comparing Id values and storing result in variable
            bool result1 = employeeA == employeeB;
            bool result2 = employeeC == employeeC;
            bool result3 = employeeA != employeeB;

            // Displaying results
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
