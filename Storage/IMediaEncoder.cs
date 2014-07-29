namespace Touch.Storage
{
    /// <summary>
    /// Media encoder.
    /// </summary>
    public interface IMediaEncoder
    {
        /// <summary>
        /// Encode the provided storage file.
        /// </summary>
        MediaEncoderJob Encode(string source, string output);

        /// <summary>
        /// Encode the provided storage file ang degerate thumbnails.
        /// </summary>
        MediaEncoderJob Encode(string source, string output, string thumbnailsOutput);
    }
}
