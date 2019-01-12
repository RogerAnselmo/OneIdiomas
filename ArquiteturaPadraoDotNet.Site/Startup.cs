using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArquiteturaPadraoDotNet.Site.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ArquiteturaPadraoDotNet.Infra.Data.Context;
using ArquiteturaPadraoDotNet.Infra.CrossCutting.Identity.Data.Models;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using ArquiteturaPadraoDotNet.Infra.CrossCutting.IoC;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ArquiteturaPadraoDotNet.Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(x =>
            {
                x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                x.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

            #region Context
            //context do Identity
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //context da Aplicação
            services.AddDbContext<ArquiteturaPadraoDotNetContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            #endregion

            #region Identity

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;  //Requer um número entre 0-9, a senha.
                options.Password.RequiredLength = 5; //O comprimento mínimo da senha.
                options.Password.RequireNonAlphanumeric = false; //Exige um caractere não alfanumérico na senha.
                options.Password.RequireUppercase = false; //Requer um caractere em letra maiuscula na senha.
                options.Password.RequireLowercase = false; //Requer um caractere minúsculo na senha.
                options.Password.RequiredUniqueChars = 1; //Requer o número de caracteres distintos na senha.

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30); //A quantidade de tempo de uma usuário é bloqueada quando ocorre um bloqueio.
                options.Lockout.MaxFailedAccessAttempts = 10; //O número de tentativas de acesso com falha até que um usuário seja bloqueado, se o bloqueio é ativado.
                options.Lockout.AllowedForNewUsers = false; //Determina se um novo usuário poderá ser bloqueado.

                // User settings
                options.User.RequireUniqueEmail = false;
            }); 
            #endregion

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(o =>
                {
                    o.LoginPath = "/Home/Index";
                    o.LogoutPath = "/Home/Index";

                });

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            NativeInjectoBootStrapper.RegisterServices(services);
        }
    }
}
