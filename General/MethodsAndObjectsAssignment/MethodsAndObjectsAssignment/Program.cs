using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiaing an Employee object and initializing with values
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Calling the superclass method
            employee.SayName();
        }
    }
}
