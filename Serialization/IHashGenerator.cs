using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Touch.Serialization
{
    /// <summary>
    /// Data hash generator.
    /// </summary>
    public interface IHashGenerator
    {
        /// <summary>
        /// Generate hash for data.
        /// </summary>
        string Generate(byte[] data);
    }
}
