using HMS.Business.Service;
using HMS.Core.Entities;
using HMS.Core.Exception;
using HMS.Core.IRepository;
using HMS.Core.IService;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HMS.Tests
{
    public class UserService_Tests
    {
        private IUserService userService;
        private Mock<IUserRepository> userRepositoryMock;

        public UserService_Tests()
        {
            this.userRepositoryMock = new Mock<IUserRepository>();
            this.userService = new UserService(userRepositoryMock.Object);
        }

        [Fact]
        public void Login_ShouldThrowNullUserNameException_WhenUserNameIsNull()
        {
            string nullUsername = null;
            string validPassword = "password.test";

            Assert.Throws<NullUserNameException>(() => userService.Login(nullUsername, validPassword));
        }

    }
}
