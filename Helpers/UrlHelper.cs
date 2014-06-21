using System;
using System.Collections.Generic;

namespace Touch.Helpers
{
    public static class UrlHelper
    {
        public static IDictionary<string,string> ParseQuery(this Uri url)
        {
            var queryParameters = new Dictionary<string,string>();
            var querySegments = url.Query.Split('&');

            foreach (var segment in querySegments)
            {
                var parts = segment.Split('=');

                if (parts.Length > 0)
                {
                    var key = parts[0].Trim(new char[] { '?', ' ' });
                    var val = parts[1].Trim();

                    queryParameters.Add(key, val);
                }
            }

            return queryParameters;
        }
    }
}

