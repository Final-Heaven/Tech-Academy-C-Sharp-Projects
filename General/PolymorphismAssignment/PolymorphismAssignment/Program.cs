using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Employee object with initial values
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // Calling method
            employee.SayName();

            // Using polymorphism to create an object of type IQuittable
            IQuittable quit = new Employee();
            // Calling method
            quit.Quit();
        }
    }
}
