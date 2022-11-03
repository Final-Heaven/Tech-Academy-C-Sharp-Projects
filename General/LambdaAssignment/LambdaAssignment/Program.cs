using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new list of employees
            List<Employee> employeeList = new List<Employee>();

            // Adding 10 employees, two of which share the first name of Joe
            employeeList.Add(new Employee { Id = 1, firstName = "John", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 2, firstName = "Jane", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 3, firstName = "Jim", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 4, firstName = "Joe", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 5, firstName = "Jessica", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 6, firstName = "Jerry", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 7, firstName = "James", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 8, firstName = "Joe", lastName = "Schmo" });
            employeeList.Add(new Employee { Id = 9, firstName = "Jack", lastName = "Doe" });
            employeeList.Add(new Employee { Id = 10, firstName = "Jasmine", lastName = "Doe" });

            /////////////////////////////////////////////////////////////////////////////////////////
            
            // Creating another list of employees
            List<Employee> newList = new List<Employee>();

            Console.WriteLine("Results of creating a new list with a foreach loop: ");

            // Using foreach loop to only add employees with the first name of Joe to the new list
            foreach (Employee employee in employeeList)
            {
                if (employee.firstName == "Joe")
                {
                    newList.Add(employee);
                    // Printing results for demonstration purposes
                    Console.WriteLine(employee.firstName + " - ID " + employee.Id);
                }
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // Creating another list of employees
            // This time, using a lambda expression to only add employees with the first name of Joe
            List<Employee> lambdaList = employeeList.Where(x => x.firstName == "Joe").ToList();

            Console.WriteLine("\nResults of creating a new list with a lambda expression: ");

            foreach (Employee employee in lambdaList)
            {
                // Printing results for demonstrastion purposes
                Console.WriteLine(employee.firstName + " - ID " + employee.Id);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // Creating yet another list of employees
            // This time, using a lambda expression to only add employees with an Id greater than 5
            List<Employee> lambdaList2 = employeeList.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nResults of creating a list only containing employees with an ID greater than 5: ");

            foreach (Employee employee in lambdaList2)
            {
                // Printing results for demonstration purposes
                Console.WriteLine(employee.firstName + " - ID " + employee.Id);
            }

            Console.ReadLine();
        }
    }
}
