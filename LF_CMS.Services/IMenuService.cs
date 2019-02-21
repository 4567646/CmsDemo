/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理菜单                                                    
*│　作    者：廖峰                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-17 17:49:27                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Services                                   
*│　接口名称： IMenuRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Core.Dependency;
using LF_CMS.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LF_CMS.Services
{
    public interface IMenuService:ISingletonDependency
    {
        Task<IEnumerable<Menu>> GetAllAsync();
        IEnumerable<Menu> GetAll();
    }
}