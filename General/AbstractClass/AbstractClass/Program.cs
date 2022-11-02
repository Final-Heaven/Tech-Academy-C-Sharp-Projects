using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Employee object with initial values
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // Calling method
            employee.SayName();
        }
    }
}
