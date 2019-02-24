/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：角色表接口实现                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                  
*│　类    名： RoleRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Core.DbHelper;
using LF_CMS.Core.Options;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using LF_CMS.Core.Repository;
using LF_CMS.Models.Entity;

namespace LF_CMS.Repository
{
    public class RoleRepository:BaseRepository<Role,Int32>, IRoleRepository
    {
        public RoleRepository(IOptionsSnapshot<DbOption> options):base(options)
        {
        }

		public int DeleteLogical(int[] ids)
        {
            string sql = "update Role set IsDelete=1 where Id in @Ids";
            return _dbConnection.Execute(sql, new
            {
                Ids = ids
            });
        }

        public async Task<int> DeleteLogicalAsync(int[] ids)
        {
            string sql = "update Role set IsDelete=1 where Id in @Ids";
            return await _dbConnection.ExecuteAsync(sql, new
            {
                Ids = ids
            });
        }

    }
}