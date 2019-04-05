/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：权限表                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： CmsDemo.Services                                  
*│　类    名： PermissionService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using CmsDemo.Models.Dto;
using CmsDemo.Models.Entity;
using LF_CMS.Repository;
using System.Collections.Generic;

namespace CmsDemo.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _repository;

        public PermissionService(IPermissionRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Permission> GetPermissionAll()
        {
            return _repository.GetPermissionAll();
        }
    }
}