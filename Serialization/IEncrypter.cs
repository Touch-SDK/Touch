using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Touch.Serialization
{
    /// <summary>
    /// Data encrypter.
    /// </summary>
    public interface IEncryper
    {
        /// <summary>
        /// Encrypt data.
        /// </summary>
        byte[] Crypt(byte[] data);

        /// <summary>
        /// Encrypt data with salt.
        /// </summary>
        byte[] Crypt(byte[] data, byte[] salt);
    }
}
