using CmsDemo.Core.Entities;
using CmsDemo.Core.Repositories;
using CmsDemo.Core.UOW;
using CmsDemo.EntityFrameWorkCore;
using CmsDemo.EntityFrameWorkCore.Repositories;

namespace CmsDemo.Services
{
    public class AdminService : CmsDemoEfRepository<Admin>, IAdminService
    {
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IRepository<Admin> _adminRepository;
        //public AdminService(IRepository<Admin> adminRepository, IUnitOfWork unitOfWork)
        //{
        //    _adminRepository = adminRepository;
        //    _unitOfWork = unitOfWork;
        //}

        public AdminService(CmsDemoDbContext dbContext) : base(dbContext)
        {
        }
        public Admin GetAdminById(int id)
        {
            return base.Get(id);
            //return _adminRepository.Get(id);
        }

        public Admin GetAdminByUserName(string userName)
        {
            return base.FirstOrDefault(m => m.UserName.Equals(userName));
            //return _adminRepository.FirstOrDefault(md => md.UserName == userName);

        }

    }
}