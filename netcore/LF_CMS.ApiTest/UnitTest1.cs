using LF_CMS.Core.Dependency;
using LF_CMS.Core.Options;
using LF_CMS.Test.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Xunit;

namespace LF_CMS.ApiTest
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
