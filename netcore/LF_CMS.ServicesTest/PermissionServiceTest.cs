using LF_CMS.Core.Dependency;
using LF_CMS.Core.Options;
using LF_CMS.Services;
using LF_CMS.Test.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LF_CMS.ServicesTest
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
