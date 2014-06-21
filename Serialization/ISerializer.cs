using System.IO;

namespace Touch.Serialization
{
    /// <summary>
    /// Object serializer.
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serialize object.
        /// </summary>
        string Serialize<T>(T obj)
            where T : class, new();

        /// <summary>
        /// Serialize object.
        /// </summary>
        void Serialize<T>(T obj, Stream output)
            where T : class, new();

        /// <summary>
        /// Deserialize data.
        /// </summary>
        T Deserialize<T>(string data)
            where T : class, new();

        /// <summary>
        /// Deserialize data.
        /// </summary>
        T Deserialize<T>(Stream stream)
            where T : class, new();
    }
}
