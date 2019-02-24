/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：权限表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Services                                   
*│　接口名称： IPermissionRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Core.Dependency;
using LF_CMS.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Services.Permission
{
    public interface IPermissionService : ISingletonDependency
    {
        IEnumerable<LF_CMS.Models.Entity.Permission> GetPermissionAll();
    }
}