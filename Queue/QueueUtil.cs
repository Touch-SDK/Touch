using System;

namespace Touch.Queue
{
    public static class QueueUtil
    {
        /// <summary>
        /// Get requests queue name.
        /// </summary>
        /// <param name="location">Location token.</param>
        public static string GetRequestsQueueName(Guid location)
        {
            return "requests-" + location.ToString("N").ToLowerInvariant();
        }
    }
}
