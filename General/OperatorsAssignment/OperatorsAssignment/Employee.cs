using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        // Id, FirstName, and LastName properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the == operator
        // Returns boolean value to display to user
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Overloading the != operator
        // Returns boolean value to display to user
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
