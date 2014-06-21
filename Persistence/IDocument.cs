using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Document.
    /// </summary>
    public interface IDocument : IEquatable<IDocument>
    {
        /// <summary>
        /// Document's hash key.
        /// </summary>
        string HashKey { get; set; }
    }
}
