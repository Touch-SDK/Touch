using System;

namespace Touch.Helpers
{
    public static class GuidHelper
    {
        public static int ToInt(this Guid value)
        {
            return value.GetHashCode();
        }
    }
}

