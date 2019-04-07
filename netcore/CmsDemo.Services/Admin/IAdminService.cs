
using CmsDemo.Core.Dependency;
using CmsDemo.Core.Entities;
using CmsDemo.Core.Repositories;

namespace CmsDemo.Services
{
    public interface IAdminService : ITransientDependency, IRepository<Admin>
    {
        Admin GetAdminById(int id);
        Admin GetAdminByUserName(string userName);
    }
}