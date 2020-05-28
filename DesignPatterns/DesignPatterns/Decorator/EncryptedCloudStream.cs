using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class EncryptedCloudStream : IStream
    {
        private IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }
        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "!+%=!%(/%GDF+!FSA";
        }
    }
}
