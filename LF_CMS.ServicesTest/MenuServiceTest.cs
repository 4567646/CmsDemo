using LF_CMS.Core.Dependency;
using LF_CMS.Core.Options;
using LF_CMS.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LF_CMS.ServicesTest
{

    public class MenuServiceTest : TestBase
    {
        private readonly IMenuService _menuService;
        public MenuServiceTest()
        {
            _menuService = _serviceProvider.GetService<IMenuService>();

        }
        [Fact]
        public void Test1()
        {
            string ss1 = AppContext.BaseDirectory;
            var list = _menuService.GetAll();
            Assert.True(list.Count() > 0);

        }




    }
}
