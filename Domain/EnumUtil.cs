using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Touch.Domain
{
    public static class Enums
    {
        /// <summary>
        /// Convert enum into another enum.
        /// </summary>
        public static T ToEnum<T>(this Enum value)
            where T : struct
        {
            return (T) Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Convert enum into a string.
        /// </summary>
        public static string ToEnumString(this Enum value)
        {
            return value.ToString("G");
        }

        /// <summary>
        /// Convert enum into a string.
        /// </summary>
        public static T FromEnumString<T>(this string value)
            where T : struct
        {
            T result = default(T);

            if (!Enum.TryParse<T>(value, out result))
                throw new FormatException("Unable to convert the string into enum: " + value);

            return result;
        }

        /// <summary>
        /// Get all enum values.
        /// </summary>
        public static IEnumerable<T> AllValues<T>(this Enum value)
            where T : struct
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
