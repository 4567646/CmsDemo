/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理菜单                                                    
*│　作    者：廖峰                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-17 17:49:27                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Services                                  
*│　类    名： MenuService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Models.Entity;
using LF_CMS.Repository;
using LF_CMS.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LF_CMS.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _repository;

        public MenuService(IMenuRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Menu>> GetAllAsync()
        {
            var list = await _repository.GetAllAsync();
            return list;
        }
        public IEnumerable<Menu> GetAll()
        {
            var list =  _repository.GetAll();
            return list;
        }
    }
}