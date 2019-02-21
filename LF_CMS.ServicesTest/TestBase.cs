using LF_CMS.Core.Dependency;
using LF_CMS.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.ServicesTest
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
            services.Configure<DbOption>(GetConfiguration().GetSection("DbOpion"));
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
