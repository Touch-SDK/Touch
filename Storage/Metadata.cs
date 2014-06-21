using System.Collections.Generic;

namespace Touch.Storage
{
    /// <summary>
    /// File metadata.
    /// </summary>
    sealed public class Metadata : Dictionary<string, string>
    {
        /// <summary>
        /// Default content type.
        /// </summary>
        private const string DefaultContentType = "application/octet-stream";

        /// <summary>
        /// Content type of the file.
        /// </summary>
        public string ContentType { get; set; }

        public Metadata()
        {
            ContentType = DefaultContentType;
        }
    }
}
