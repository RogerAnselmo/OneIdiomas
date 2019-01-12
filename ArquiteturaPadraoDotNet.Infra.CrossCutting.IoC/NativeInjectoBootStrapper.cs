using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Infra.CrossCutting.IoC
{
    public class NativeInjectoBootStrapper
    {
        public static IServiceCollection Services { get; set; }

        public static void RegisterServices(IServiceCollection services)
        {
            Services = services;

            //Application
            //services.AddScoped<IAppService, AppService>();
            
            //Service
            //services.AddScoped<IService, Service>();

            //Repository
            //services.AddScoped<IRepository, Repository>();

            //Infra - IoC
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IUnitOfWorkTransaction, UnitOfWorkTransaction>();

            //Context
            //services.AddScoped<Context>();

        }
    }
}
