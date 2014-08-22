using System.Collections.Generic;

namespace Touch.Email
{
    public sealed class EmailMessage
    {
        public IList<string> Recipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
