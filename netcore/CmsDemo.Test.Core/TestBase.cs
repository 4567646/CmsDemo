using CmsDemo.Core.CodeGenerator;
using CmsDemo.Core.Dependency;
using CmsDemo.Core.Repositories;
using CmsDemo.Core.UOW;
using CmsDemo.EntityFrameWorkCore;
using CmsDemo.EntityFrameWorkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CmsDemo.Test.Core
{
    /// <summary>
    /// 测试基类
    /// </summary>
    public class TestBase
    {
        protected readonly IServiceProvider _serviceProvider;
        public TestBase()
        {
            _serviceProvider = BuildServiceForSqlServer();
        }
        /// <summary>
        /// 构造依赖注入容器，然后传入参数
        /// </summary>
        /// <returns></returns>
        private static IServiceProvider BuildServiceForSqlServer()
        {
            CodeGenerator codeGenerator = new CodeGenerator(new CmsDemo.Core.Options.CodeGenerateOption()
            {
                Author = "LF",
                GeneratorTime = DateTime.Now.ToString(),
                IServicesNamespace = "CmsDemo.Services",
                OutputPath = "F:\\CodeGenerator",
                ServicesNamespace = "CmsDemo.Services",
                EntityLib= "CmsDemo.Core",
                EntityNamespace = "CmsDemo.Core.Entities"

            }, true);
            var services = new ServiceCollection();
            services.AddDbContext<CmsDemoDbContext>(options =>
                    options.UseSqlServer(GetConfiguration().GetConnectionString("DefaultConnectionString"))
           );
            services.AddScoped<IUnitOfWork, UnitOfWork<CmsDemoDbContext>>();
            services.AddTransient(typeof(IRepository<>), typeof(CmsDemoEfRepository<>));
            services.AddTransient(typeof(IRepository<,>), typeof(CmsDemoEfRepository<,>));
            return IocManager.Instance.Initialize(services);
        }
        /// <summary>
        /// 获取配置文件
        /// </summary>
        /// <returns></returns>
        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables();
            return builder.Build();
        }
    }
}
