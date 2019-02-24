using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using LF.CMS.Api.AutoMapperModule;
using LF.CMS.Api.Dto.Permission;
using LF_CMS.Core.Dependency;
using LF_CMS.Core.Options;
using LF_CMS.Models.Entity;
using LF_CMS.Repository;
using LF_CMS.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LF.CMS.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<DbOption>(Configuration.GetSection("DbOpion"));

            //services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            #region AutoMapper

            //配置automapper
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            //    cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
            //    //cfg.CreateMap<Permission, PermissionDto>();
            //    //cfg.AddProfile<PermissionProfile>();
            //});
            Mapper.Initialize(cfg => cfg.AddProfiles(typeof(PermissionProfile)));

            services.AddMvc();
            #endregion

            #region AutoFace
            return IocManager.Instance.Initialize(services);
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
