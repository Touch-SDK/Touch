using System;
using System.IO;

namespace Touch.Persistence
{
    /// <summary>
    /// Persistent data storage.
    /// </summary>
    public interface IBlob
    {
        /// <summary>
        /// Blob name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Read data.
        /// </summary>
        byte[] Read();

        /// <summary>
        /// Read binary data.
        /// </summary>
        Stream ReadBinary();

        /// <summary>
        /// Write data.
        /// </summary>
        void Write(byte[] data);

        /// <summary>
        /// Write binary data.
        /// </summary>
        Stream WriteBinary();

        /// <summary>
        /// Last modification date.
        /// </summary>
        DateTime LastModified { get; }
    }
}
