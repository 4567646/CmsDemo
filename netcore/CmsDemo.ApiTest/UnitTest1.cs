using CmsDemo.Core.Dependency;
using CmsDemo.Core.Options;
using CmsDemo.Test.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Xunit;

namespace CmsDemo.ApiTest
{
    public class UnitTest1 : TestBase
    {
        //private readonly IMenuService _menuService;
        public UnitTest1()
        {
           // _menuService = _serviceProvider.GetService<IMenuService>();

        }
        [Fact]
        public void Test1()
        {
            //string ss1 = AppContext.BaseDirectory;
            //var list = _menuService.GetAll();
            //Assert.True(list.Count() > 0);

        }


    }
}
