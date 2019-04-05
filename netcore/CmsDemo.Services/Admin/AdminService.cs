using CmsDemo.EntityFrameWorkCore;
using CmsDemo.Models.Entities;

namespace CmsDemo.Services
{
    public class AdminService : CmsDemoEfRepositoryBase<Admin>, IAdminService
    {
        public AdminService(CmsDemoDbContext dbContext) : base(dbContext)
        {
        }
        public Admin GetAdminById(int id)
        {
            return base.Get(id);
        }

        public Admin GetAdminByUserName(string userName)
        {
            return base.FirstOrDefault(md => md.UserName==userName);

        }

    }
}