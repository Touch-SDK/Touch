using System;

namespace Touch.Storage
{
    /// <summary>
    /// Temporary directory.
    /// </summary>
    public interface ITemporaryDirectory : IDisposable
    {
        /// <summary>
        /// Directory path.
        /// </summary>
        string Path { get; }
    }
}
