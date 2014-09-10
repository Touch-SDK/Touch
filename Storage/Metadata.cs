using System;
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

        /// <summary>
        /// Last modification date of the file.
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// ETag of the file.
        /// </summary>
        public string ETag { get; set; }

        public Metadata()
        {
            ContentType = DefaultContentType;
        }
    }
}
