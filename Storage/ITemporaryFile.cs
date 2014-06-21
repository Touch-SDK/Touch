using System;
using System.IO;

namespace Touch.Storage
{
    /// <summary>
    /// Temporary file.
    /// </summary>
    public interface ITemporaryFile : IDisposable
    {
        /// <summary>
        /// File stream.
        /// </summary>
        Stream Stream { get; }
    }
}
