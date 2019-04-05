/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：权限表接口实现                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                  
*│　类    名： PermissionRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using CmsDemo.Core.Options;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using CmsDemo.Core.Repository;
using CmsDemo.Models.Entity;
using System.Collections.Generic;
using CmsDemo.Core.Dependency;

namespace LF_CMS.Repository
{
    public class PermissionRepository : BaseRepository<Permission, Int32>,IPermissionRepository
    {
        public PermissionRepository(IOptionsSnapshot<DbOption> options) : base(options)
        {

        }

        public int DeleteLogical(int[] ids)
        {
            string sql = "update Permission set IsDelete=1 where Id in @Ids";
            return _dbConnection.Execute(sql, new
            {
                Ids = ids
            });
        }

        public async Task<int> DeleteLogicalAsync(int[] ids)
        {
            string sql = "update Permission set IsDelete=1 where Id in @Ids";
            return await _dbConnection.ExecuteAsync(sql, new
            {
                Ids = ids
            });
        }

        public IEnumerable<Permission> GetPermissionAll()
        {
            string sql = @"SELECT Id,Name,ParentId,IconUrl,LinkUrl,Sort,Type,AddManagerId,UpdateManagerId,IsDisplay,IsDelete,UpdateTime,CreateTime
                                FROM dbo.Permission
                                where IsDelete = 0 and IsDisplay = 1";
            return _dbConnection.Query<Permission>(sql);

        }

    }
}