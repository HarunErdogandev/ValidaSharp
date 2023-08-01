using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ValidaSharp
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; private set; }

        public ValidationException(List<string> errors) : base("Validation failed.")
        {
            Errors = errors;
        }
    }
}

