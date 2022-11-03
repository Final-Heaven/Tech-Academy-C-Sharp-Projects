using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Takes generic type parameter
    public class Employee<T>
    {
        // Data type is generic list
        public List<T> Things { get; set; }
    }
}
