using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Chain
    {
        // Property
        public string ChainString;

        // Chaining two constructors together
        // Has string parameter and assigns value to property ChainString,
        // but if nothing is passed in, uses default instead
        public Chain() : this("Default")
        {

        }

        public Chain(string ChainString)
        {
            this.ChainString = ChainString;
        }
    }
}
