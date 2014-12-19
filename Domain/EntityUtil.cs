using System;

namespace Touch.Domain
{
    public static class EntityUtil
    {
        /// <summary>
        /// Get string representation for <c>IDocument</c> usage.
        /// </summary>
        public static string ToTokenString(this Guid value)
        {
            return value.ToString("N").ToLowerInvariant();
        }
    }
}
