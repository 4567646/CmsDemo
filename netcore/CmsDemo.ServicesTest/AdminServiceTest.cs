using CmsDemo.Core.Entities;
using CmsDemo.Core.UOW;
using CmsDemo.Services.Admin;
using CmsDemo.Test.Core;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Extensions.Ordering;

namespace CmsDemo.ServicesTest
{

    public class AdminServiceTest : TestBase
    {
        private readonly IAdminService _adminService;
        protected readonly IUnitOfWork _unitOfWork;

        public AdminServiceTest()
        {
            _adminService = _serviceProvider.GetService<IAdminService>();

            _unitOfWork = _serviceProvider.GetService<IUnitOfWork>();
        }

        [Theory, Order(1)]
        [InlineData("zhangsan", "ÕÅÈý", "123456")]
        //[Ignore("ÔÝÊ±ºöÂÔ")]
        public void CanAddOneAdmin(string userName, string name, string password)
        {
            Admin admin = new Admin()
            {
                UserName = userName,
                Name = name,
                PassWord = password,
            };
            var newAdmin = _adminService.Insert(admin);
            //_unitOfWork.SaveChanges();
            Assert.NotNull(newAdmin);
        }
        [Fact, Order(2)]
        public void GetOneAdminInfo()
        {
            var model = _adminService.GetAdminByUserName("admin");
            Assert.Equal("admin", model.UserName);
        }



    }
}
