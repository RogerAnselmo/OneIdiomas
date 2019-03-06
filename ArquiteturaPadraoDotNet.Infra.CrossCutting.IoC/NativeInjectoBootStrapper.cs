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
            services.AddScoped<IAcademicoAppService, AcademicoAppService>();
            services.AddScoped<IGeralAppService, GeralAppService>();
            services.AddScoped<ISegurancaAppService, SegurancaAppService>();

            //Service
            #region Serviços Acadêmico
            services.AddScoped<IACAlunoService, ACAlunoService>();
            services.AddScoped<IACAlunoResponsavelService, ACAlunoResponsavelService>();
            services.AddScoped<IACResponsavelService, ACResponsavelService>();
            #endregion

            #region Serviços Geral
            services.AddScoped<IGEUFService, GEUFService>();
            services.AddScoped<IGECidadeService, GECidadeService>();
            services.AddScoped<ISEGUsuarioService, SEGUsuarioService>();
            services.AddScoped<IGEEnderecoService, GEEnderecoService>();
            services.AddScoped<IGEBairroService, GEBairroService>();
            #endregion

            #region Serviços Segurança
            services.AddScoped<ISEGUsuarioPerfilService, SEGUsuarioPerfilService>();
            #endregion

            //Repository

            #region Repositório Acadêmico
            services.AddScoped<IACAlunoRepository, ACAlunoRepository>();
            services.AddScoped<IACAlunoResponsavelRepository, ACAlunoResponsavelRepository>();
            services.AddScoped<IACResponsavelRepository, ACResponsavelRepository>();
            #endregion

            #region Repositório Geral
            services.AddScoped<IGECidadeRepository, GECidadeRepository>();
            services.AddScoped<IGEUFRepository, GEUFRepository>();
            services.AddScoped<ISEGUsuarioPerfilRepository, SEGUsuarioPerfilRepository>();
            services.AddScoped<IGEEnderecoRepository, GEEndercoRepository>();
            services.AddScoped<IGEBairroRepository, GEBairroRepository>();
            #endregion

            #region repositório Segurança
            services.AddScoped<ISEGUsuarioRepository, SEGUsuarioRepositopry>(); 
            #endregion

            //Infra - IoC
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkTransaction, UnitOfWorkTransaction>();

            //Context
            services.AddScoped<OneContext>();
        }
    }
}
