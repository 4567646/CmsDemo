/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理菜单                                                    
*│　作    者：廖峰                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-17 17:49:27                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                   
*│　接口名称： IMenuRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Models.Entity;
using System;
using System.Threading.Tasks;
using LF_CMS.Core.Repository;
using System.Collections.Generic;
using LF_CMS.Core.Dependency;

namespace LF_CMS.Repository
{
    public interface IMenuRepository : IBaseRepository<Menu, Int32>, ISingletonDependency
    {
        /// <summary>
        /// 逻辑删除返回影响的行数
        /// </summary>
        /// <param name="ids">需要删除的主键数组</param>
        /// <returns>影响的行数</returns>
        Int32 DeleteLogical(Int32[] ids);
        /// <summary>
        /// 逻辑删除返回影响的行数（异步操作）
        /// </summary>
        /// <param name="ids">需要删除的主键数组</param>
        /// <returns>影响的行数</returns>
        Task<Int32> DeleteLogicalAsync(Int32[] ids);
        /// <summary>
        /// 获取所有菜单
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Menu>> GetAllAsync();
        /// <summary>
        /// 获取所有菜单
        /// </summary>
        /// <returns></re
        IEnumerable<Menu> GetAll();

    }
}