using CmsDemo.Core.Dependency;
using CmsDemo.Core.Options;
using CmsDemo.Models.Entities;
using CmsDemo.Services;
using CmsDemo.Test.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CmsDemo.ServicesTest
{

    public class AdminServiceTest : TestBase
    {
        private readonly IAdminService _adminService;
        public AdminServiceTest()
        {
            _adminService = _serviceProvider.GetService<IAdminService>();

        }
        [Fact]
        public void CanAddOneAdmin()
        {
            Admin admin = new Admin()
            {
                UserName = "zhangsan",
                Name = "ÕÅÈý",
                PassWord = "123qwe",
            };
            var newAdmin = _adminService.GetAdminByUserName(admin.UserName);
            if (newAdmin != null)
                _adminService.Update(newAdmin);
            else
            {
                newAdmin = _adminService.Insert(admin);
            }
            Assert.True(admin.Equals(newAdmin));
            Assert.True(newAdmin.Id > 0);
            newAdmin.UserName.ShouldBe("zhangsan");
        }




    }
}
