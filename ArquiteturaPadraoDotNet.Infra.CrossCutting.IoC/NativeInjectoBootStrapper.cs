using Microsoft.Extensions.DependencyInjection;
using One.Application.Interfaces;
using One.Application.Services;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Services;
using One.Infra.Data.Context;
using One.Infra.Data.Interface;
using One.Infra.Data.Repository;
using One.Infra.Data.Uow;

namespace One.Infra.CrossCutting.IoC
{
    public class NativeInjectoBootStrapper
    {
        public static IServiceCollection Services { get; set; }

        public static void RegisterServices(IServiceCollection services)
        {
            Services = services;

            //Application
            services.AddScoped<IUsuarioExternoAppservice, UsuarioExternoAppService>();
            services.AddScoped<IUsuarioOneAppService, UsuarioOneAppService>();

            //Service
            services.AddScoped<IGEUFService, GEUFService>();
            services.AddScoped<IGECidadeService, GECidadeService>();
            services.AddScoped<ISEGUsuarioService, SEGUsuarioService>();
            services.AddScoped<ISEGUsuarioPerfilService, SEGUsuarioPerfilService>();
            services.AddScoped<IGEEnderecoService, GEEnderecoService>();
            services.AddScoped<IACAlunoService, ACAlunoService>();
            services.AddScoped<IACAlunoResponsavelService, ACAlunoResponsavelService>();
            services.AddScoped<IACResponsavelService, ACResponsavelService>();

            //Repository
            services.AddScoped<IGECidadeRepository, GECidadeRepository>();
            services.AddScoped<IGEUFRepository, GEUFRepository>();
            services.AddScoped<ISEGUsuarioRepository, SEGUsuarioRepositopry>();
            services.AddScoped<ISEGUsuarioPerfilRepository, SEGUsuarioPerfilRepository>();
            services.AddScoped<IGEEnderecoRepository, GEEndercoRepository>();
            services.AddScoped<IACAlunoRepository, ACAlunoRepository>();
            services.AddScoped<IACAlunoResponsavelRepository, ACAlunoResponsavelRepository>();
            services.AddScoped<IACResponsavelRepository, ACResponsavelRepository>();

            //Infra - IoC
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkTransaction, UnitOfWorkTransaction>();

            //Context
            services.AddScoped<OneContext>();
        }
    }
}
