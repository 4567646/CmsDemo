using LF_CMS.Core.Dependency;
using LF_CMS.Core.Options;
using LF_CMS.Repository;
using LF_CMS.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Xunit;

namespace LF_CMS.ApiTest
{
    public class UnitTest1
    {
        private readonly IMenuService _menuService;
        public UnitTest1()
        {
            var iocManager = BuildServiceForSqlServer();
            _menuService = iocManager.GetService<IMenuService>();

        }
        [Fact]
        public void Test1()
        {
            string ss1 = AppContext.BaseDirectory;
            var list = _menuService.GetAll();
            Assert.True(list.Count() > 0);

        }



        /// <summary>
        /// 构造依赖注入容器，然后传入参数
        /// </summary>
        /// <returns></returns>
        public static IServiceProvider BuildServiceForSqlServer()
        {
            var services = new ServiceCollection();
            services.Configure<DbOption>(GetConfiguration().GetSection("DbOpion"));
            return services.BuildServiceProvider(); //构建服务提供程序
            //return IocManager.Instance.Initialize(services);
        }

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables();
            return builder.Build();
        }

    }
}
