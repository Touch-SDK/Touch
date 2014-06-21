using System;
using System.Linq;

namespace Touch.Helpers
{
    static public class TypeExtension
    {
        /// <summary>
        /// Check if type implements an interface.
        /// </summary>
        /// <param name="type">Type to check.</param>
        /// <param name="interfaceType">Interface type to look for.</param>
        static public bool ImplementsInterface(this Type type, Type interfaceType)
        {
            if (interfaceType == null) throw new ArgumentNullException("interfaceType");
            
            return type.GetInterfaces().Any(x => x.FullName == interfaceType.FullName);
        }

        /// <summary>
        /// Check if type is nullable.
        /// </summary>
        static public bool IsNullable(this Type type)
        {
            return (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)));
        }
    }
}
