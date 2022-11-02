using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        // Properties of first name and last name
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Virtual keyword allows method to be overridden in inheriting class
        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
