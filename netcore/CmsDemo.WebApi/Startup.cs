using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using CmsDemo.WebApi.AutoMapperProfile;
using CmsDemo.WebApi.Middleware;
using CmsDemo.Core.Dependency;
using CmsDemo.Core.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using CmsDemo.EntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;

namespace CmsDemo.WebApi
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
            services.AddDbContext<CmsDemoDbContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"))
            );
            //注入Redis缓存
            //services.AddSingleton(typeof(IRedisCacheService), new RedisCacheService(new RedisCacheOptions()
            //{
            //    Configuration = Configuration.GetSection("Cache:ConnectionString").Value,
            //    InstanceName = Configuration.GetSection("Cache:InstanceName").Value,
            //}));
            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = Configuration.GetSection("Cache:ConnectionString").Value;
                option.InstanceName = Configuration.GetSection("Cache:InstanceName").Value;
            });

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

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(WebApiResultMiddleware));
            });
            #endregion

            #region Swagger
            // Register the Swagger generator, defining 1 or more Swagger documents
            AddSwaggerGen(services);
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
            #region 各种中间件

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "LF_DEMO API V1");
                c.RoutePrefix = string.Empty;
            });



            #endregion
            app.UseHttpsRedirection();
            app.UseMvc();
        }

        /// <summary>
        /// swagger配置
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private Startup AddSwaggerGen(IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = "https://twitter.com/spboyer"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            return this;
        }
    }
}
