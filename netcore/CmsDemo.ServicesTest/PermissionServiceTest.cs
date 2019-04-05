using CmsDemo.Core.Dependency;
using CmsDemo.Core.Options;
using CmsDemo.Services;
using CmsDemo.Test.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CmsDemo.ServicesTest
{

    public class PermissionServiceTest : TestBase
    {
        private readonly IPermissionService _menuService;
        public PermissionServiceTest()
        {
            _menuService = _serviceProvider.GetService<IPermissionService>();

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
