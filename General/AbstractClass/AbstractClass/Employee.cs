using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        // Overriding SayName() method from Person class
        // Allows employee objects access to this method and any changes to it here
        public override void SayName()
        {
            base.SayName();
            Console.ReadLine();
        }
    }
}
