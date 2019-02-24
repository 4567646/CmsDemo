using LF_CMS.Core.CodeGenerator;
using LF_CMS.Core.Dependency;
using LF_CMS.Core.Model;
using LF_CMS.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LF_CMS.Test.Core
{
    /// <summary>
    /// 测试基类
    /// </summary>
    public class TestBase
    {
        protected IServiceProvider _serviceProvider { get; }
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
            var services = new ServiceCollection();
            services.Configure<CodeGenerateOption>(options =>
            {
                options.ConnectionString = "Data Source=.;Initial Catalog=LF_CMS;User ID=sa;Password=1988613;Persist Security Info=True;Max Pool Size=50;Min Pool Size=0;Connection Lifetime=300;";
                options.DbType = DatabaseType.SqlServer.ToString();//数据库类型是SqlServer,其他数据类型参照枚举DatabaseType
                options.Author = "liaofeng";//作者名称
                options.OutputPath = "F:\\Code\\LF_CMS_CodeGenerator";//模板代码生成的路径
                options.ModelsNamespace = "LF_CMS.Models.Entity";//实体命名空间
                options.IRepositoryNamespace = "LF_CMS.Repository";//仓储接口命名空间
                options.RepositoryNamespace = "LF_CMS.Repository";//仓储命名空间
                options.IServicesNamespace = "LF_CMS.Services";//服务接口命名空间
                options.ServicesNamespace = "LF_CMS.Services";//服务命名空间


            });
            services.Configure<DbOption>(GetConfiguration().GetSection("DbOpion"));
            services.AddScoped<CodeGenerator>();
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
