using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Inherits Person class and IQuittable interface
    public class Employee : Person, IQuittable
    {
        // Overriding SayName() method from Person class
        // Allows employee objects access to this method and any changes to it here
        public override void SayName()
        {
            base.SayName();
            Console.ReadLine();
        }

        // Implementation of method
        public void Quit()
        {
            // Exits program
            System.Environment.Exit(0);
        }
    }
}
