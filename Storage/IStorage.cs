using System.IO;

namespace Touch.Storage
{
    /// <summary>
    /// File storage.
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Check if bucket contains the requested file.
        /// </summary>
        /// <param name="token">File token.</param>
        bool HasFile(string token);

        /// <summary>
        /// Check if bucket contains the requested file.
        /// </summary>
        /// <param name="token">File token.</param>
        /// <param name="metadata">File metadata, if any.</param>
        bool HasFile(string token, out Metadata metadata);

        /// <summary>
        /// Put file into the storage.
        /// </summary>
        /// <param name="file">File stream.</param>
        /// <param name="token">Unique file identifier.</param>
        void PutFile(Stream file, string token);

        /// <summary>
        /// Put file into the storage.
        /// </summary>
        /// <param name="file">File stream.</param>
        /// <param name="token">Unique file identifier.</param>
        /// <param name="metadata">File metadata.</param>
        void PutFile(Stream file, string token, Metadata metadata);

        /// <summary>
        /// Put metadata into the storage.
        /// </summary>
        /// <param name="token">Unique file identifier.</param>
        /// <param name="metadata">File metadata.</param>
        void PutMetadata(string token, Metadata metadata);

        /// <summary>
        /// Get file metadata.
        /// </summary>
        /// <param name="token">Unique file identifier.</param>
        /// <returns>File metadata.</returns>
        Metadata GetMetadata(string token);

        /// <summary>
        /// Get file from the storage.
        /// </summary>
        /// <param name="token">Unique file identifier.</param>
        /// <returns>File stream.</returns>
        Stream GetFile(string token);

        /// <summary>
        /// Get file from the storage.
        /// </summary>
        /// <param name="token">Unique file identifier.</param>
        /// <param name="metadata">File metadata.</param>
        /// <returns>File stream.</returns>
        Stream GetFile(string token, out Metadata metadata);

        /// <summary>
        /// Remove file from the storage.
        /// </summary>
        /// <param name="token">Unique file identifier.</param>
        void RemoveFile(string token);

        /// <summary>
        /// Get public file URL.
        /// </summary>
        /// <param name="token">File token.</param>
        /// <returns>URL of the file.</returns>
        string GetPublicUrl(string token);

        /// <summary>
        /// Storage is public and its contents can be accessed by an authorized users by a URL.
        /// </summary>
        bool IsPublic { get; }
    }
}
