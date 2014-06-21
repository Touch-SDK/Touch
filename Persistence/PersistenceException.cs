using System;
using System.Runtime.Serialization;

namespace Touch.Persistence.Exceptions
{
    public abstract class PersistenceException : Exception
    {
        protected PersistenceException() { }
        protected PersistenceException(string message) : base(message) { }
        protected PersistenceException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ObjectNotUniqueException : PersistenceException
    {
        public ObjectNotUniqueException() { }
        public ObjectNotUniqueException(string message) : base(message) { }
        public ObjectNotUniqueException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ObjectNotFoundException : PersistenceException
    {
        public ObjectNotFoundException() { }
        public ObjectNotFoundException(string message) : base(message) { }
        public ObjectNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
