using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.Encryption
{
    public abstract class HMSEncryptor
    {
        protected string plainText;
        protected string cipherText;

        public HMSEncryptor(string plainText)
        {
            this.plainText = plainText;
        }

        public string GetCipherText()
        {
            return cipherText;
        }
    }
}
