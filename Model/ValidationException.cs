using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch.Model
{
    public class ValidationException : BusinessException
    {
        public ValidationException(string message, string argumentName = null, Exception e = null)
            : base(message, e)
        {
            ArgumentName = argumentName;
        }

        public readonly string ArgumentName;
    }
}
