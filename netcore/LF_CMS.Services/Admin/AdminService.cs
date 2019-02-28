/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：用户表                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Services                                  
*│　类    名： AdminService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Models.Dto.Admin;
using LF_CMS.Models.Entity;
using LF_CMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repository;

        public AdminService(IAdminRepository repository)
        {
            _repository = repository;
        }
        public Admin GetAdminById(int id)
        {
            return _repository.GetAdminById(id);
        }

        public Admin GetAdminByUserName(string userName)
        {
            return _repository.GetAdminByUserName(userName);

        }
    }
}