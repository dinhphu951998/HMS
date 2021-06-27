using System;
using System.Collections.Generic;
using System.Text;
using HMS.Business.Repository;
using HMS.Business.Service;
using HMS.Core.IRepository;
using HMS.Core.IService;
using Microsoft.Extensions.DependencyInjection;

namespace HMS.Core.Container
{
    public class DefaultAspNetCoreContainer : HMSContainer
    {
        private IServiceCollection services;

        public DefaultAspNetCoreContainer(IServiceCollection services)
        {
            this.services = services;
        }

        public override T Resolve<T>()
        {
            throw new NotImplementedException();
        }

        public override void RegisterAllNeeded()
        {
            RegisterRepositories();
            RegisterServices();
        }

        private void RegisterServices()
        {
            services.AddScoped<IUserService, UserService>();
        }

        private void RegisterRepositories()
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
