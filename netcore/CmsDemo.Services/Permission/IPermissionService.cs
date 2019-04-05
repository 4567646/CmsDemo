/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：权限表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： CmsDemo.Services                                   
*│　接口名称： IPermissionRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using CmsDemo.Core.Dependency;
using CmsDemo.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsDemo.Services
{
    public interface IPermissionService : ISingletonDependency
    {
        IEnumerable<CmsDemo.Models.Entity.Permission> GetPermissionAll();
    }
}