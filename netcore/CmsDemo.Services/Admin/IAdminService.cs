
using CmsDemo.Core.Dependency;
using CmsDemo.EntityFrameWorkCore.Repositories;
using CmsDemo.Models.Entities;

namespace CmsDemo.Services
{
    public interface IAdminService : IRepository<Admin>, ISingletonDependency
    {
        Admin GetAdminById(int id);
        Admin GetAdminByUserName(string userName);
    }
}