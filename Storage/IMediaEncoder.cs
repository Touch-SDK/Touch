namespace Touch.Storage
{
    /// <summary>
    /// Media encoder.
    /// </summary>
    public interface IMediaEncoder
    {
        /// <summary>
        /// Encoded the provided storage file.
        /// </summary>
        MediaEncoderJob Encode(string source, string output);
    }
}
