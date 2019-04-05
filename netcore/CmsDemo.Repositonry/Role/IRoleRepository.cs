/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：角色表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                   
*│　接口名称： IRoleRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using CmsDemo.Models.Entity;
using System;
using System.Threading.Tasks;
using CmsDemo.Core.Repository;

namespace LF_CMS.Repository
{
    public interface IRoleRepository : IBaseRepository<Role, Int32>
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
    }
}