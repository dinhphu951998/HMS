using HMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.IService
{
    public interface IUserService
    {
        User Login(string username, string password);
    }
}
