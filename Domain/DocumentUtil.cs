using System;
using System.Globalization;

namespace Touch.Domain
{
    public static class DocumentUtil
    {
        /// <summary>
        /// Get string representation for <c>IDocument</c> usage.
        /// </summary>
        public static string ToDocumentString(this DateTime value)
        {
            return value.ToUniversalTime().ToString(DateTimeFormatInfo.InvariantInfo.SortableDateTimePattern);
        }

        /// <summary>
        /// Get value from <c>IDocument</c> string representation.
        /// </summary>
        public static DateTime FromDocumentString(this string value)
        {
            var date = DateTime.ParseExact(value, DateTimeFormatInfo.InvariantInfo.SortableDateTimePattern, CultureInfo.InvariantCulture);
            return new DateTime(date.Ticks, DateTimeKind.Utc);
        }
    }
}
