using HMS.Core.Encryption;
using HMS.Core.Entities;
using HMS.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS.Business.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> userCollection;
        public UserRepository()
        {
            userCollection = new List<User>()
            {

            };
        }
        public User Login(string username, HMSEncryptor encryptor)
        {
            return userCollection.FirstOrDefault(u => string.Equals(username, u.Username) && encryptor.GetCipherText().Equals(u.Password));
        }
    }
}
