using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch.Model
{
    public class EntityException : BusinessException
    {
        public EntityException(Guid token)
            : this(token, EntityExceptionCause.Undefined)
        {
        }

        public EntityException(Guid token, EntityExceptionCause cause)
        {
            Token = token;
            Cause = cause;
        }

        public readonly Guid Token;
        public readonly EntityExceptionCause Cause;
    }

    public enum EntityExceptionCause
    {
        Undefined,
        Missing
    }
}
