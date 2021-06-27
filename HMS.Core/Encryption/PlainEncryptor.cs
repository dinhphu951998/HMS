using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.Encryption
{
    public class PlainEncryptor : HMSEncryptor
    {
        public PlainEncryptor(string plainText) : base(plainText)
        {
            this.cipherText = plainText;
        }
    }
}
