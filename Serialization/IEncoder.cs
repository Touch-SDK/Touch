namespace Touch.Serialization
{
    /// <summary>
    /// Symmetrical encoder.
    /// </summary>
    public interface IEncoder
    {
        /// <summary>
        /// Encode data.
        /// </summary>
        byte[] Encode(byte[] data);

        /// <summary>
        /// Dencode data.
        /// </summary>
        byte[] Decode(byte[] data);
    }
}
