using HMS.Core.Entities;
using HMS.Core.Exception;
using HMS.Core.IRepository;
using HMS.Core.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Business.Service
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username)) throw new NullUserNameException("error message");

            return null;
        }
    }
}
