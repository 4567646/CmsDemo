/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：权限表                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Services                                  
*│　类    名： PermissionService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Models.Dto;
using LF_CMS.Repository;
using LF_CMS.Services.Permission;
using System.Collections.Generic;

namespace LF_CMS.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _repository;

        public PermissionService(IPermissionRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<LF_CMS.Models.Entity.Permission> GetPermissionAll()
        {
            return _repository.GetPermissionAll();
        }
    }
}