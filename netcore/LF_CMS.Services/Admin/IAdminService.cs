/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：用户表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Services                                   
*│　接口名称： IAdminRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Core.Dependency;
using LF_CMS.Models.Dto.Admin;
using LF_CMS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Services
{
    public interface IAdminService : ISingletonDependency
    {
        Admin GetAdminById(int id);
        Admin GetAdminByUserName(string userName);
    }
}