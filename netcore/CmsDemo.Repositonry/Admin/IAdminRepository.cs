/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：用户表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                   
*│　接口名称： IAdminRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using CmsDemo.Models.Entity;
using System;
using System.Threading.Tasks;
using CmsDemo.Core.Repository;
using CmsDemo.Models;
using CmsDemo.Core.Dependency;

namespace LF_CMS.Repository
{
    public interface IAdminRepository : IBaseRepository<Admin, Int32>, ISingletonDependency
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
        Admin GetAdminByUserName(string userName);
        Admin GetAdminById(int id);
    }
}