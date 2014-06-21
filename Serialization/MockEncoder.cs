namespace Touch.Serialization
{
    /// <summary>
    /// Mock encoder.
    /// </summary>
    sealed public class MockEncoder : IEncoder
    {
        public byte[] Encode(byte[] data)
        {
            return data;
        }

        public byte[] Decode(byte[] data)
        {
            return data;
        }
    }
}
