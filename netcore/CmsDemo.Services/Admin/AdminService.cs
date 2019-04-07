using CmsDemo.Core.Entities;
using CmsDemo.Core.Repositories;
using CmsDemo.Core.UOW;

namespace CmsDemo.Services.Admin
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Core.Entities.Admin> _adminRepository;
        public AdminService(IRepository<Core.Entities.Admin> adminRepository, IUnitOfWork unitOfWork)
        {
            _adminRepository = adminRepository;
            _unitOfWork = unitOfWork;
        }

        public Core.Entities.Admin GetEntityById(int id)
        {
            return _adminRepository.Get(id);
        }

        public Core.Entities.Admin GetAdminByUserName(string userName)
        {
            return _adminRepository.FirstOrDefault(md => md.UserName == userName);

        }
        public void Delete(int id)
        {
            _adminRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public Core.Entities.Admin Insert(Core.Entities.Admin admin)
        {
            var model = _adminRepository.Insert(admin);
            _unitOfWork.SaveChanges();
            return model;
        }

        public Core.Entities.Admin Update(Core.Entities.Admin admin)
        {
            var model = _adminRepository.Update(admin);
            _unitOfWork.SaveChanges();
            return model;
        }
    }
}