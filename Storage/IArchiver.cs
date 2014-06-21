using System.IO;

namespace Touch.Storage
{
    /// <summary>
    /// File archiver.
    /// </summary>
    public interface IArchiver
    {
        /// <summary>
        /// Extract an archive.
        /// </summary>
        /// <param name="archive">Archive stream.</param>
        /// <param name="outputPath">Output path.</param>
        void Extract(Stream archive, string outputPath);

        /// <summary>
        /// Create an archive.
        /// </summary>
        /// <param name="directoryPath">Directory to archive.</param>
        /// <param name="output">Output stream.</param>
        void Compress(string directoryPath, Stream output);
    }
}
