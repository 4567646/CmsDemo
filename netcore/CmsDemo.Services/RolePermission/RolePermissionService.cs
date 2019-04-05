/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：角色权限表                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： CmsDemo.Services                                  
*│　类    名： RolePermissionService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Services
{
    public class RolePermissionService: IRolePermissionService
    {
        private readonly IRolePermissionRepository _repository;

        public RolePermissionService(IRolePermissionRepository repository)
        {
            _repository = repository;
        }
    }
}