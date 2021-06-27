using System;
using System.Collections.Generic;
using System.Text;
using HMS.Core.Encryption;
using HMS.Core.Entities;

namespace HMS.Core.IRepository
{
    public interface IUserRepository
    {
        User Login(string username, HMSEncryptor encryptor);
    }
}
