namespace Touch.Storage
{
    /// <summary>
    /// Temporary file storage.
    /// </summary>
    public interface ITemporaryStorage
    {
        /// <summary>
        /// Create new temporary file.
        /// </summary>
        /// <returns>New temporary file.</returns>
        ITemporaryFile CreateFile();

        /// <summary>
        /// Create new temporary directory.
        /// </summary>
        /// <returns>New temporary directory.</returns>
        ITemporaryDirectory CreateDirectory();
    }
}
